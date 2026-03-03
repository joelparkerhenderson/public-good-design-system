using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A menu is a container for a list of actions or options, using the ARIA menu role with full
/// keyboard navigation support. Menus are typically used for context menus, action menus triggered
/// by buttons, and dropdown menus that present a set of commands or functions. Each item in the
/// menu is a discrete action rather than a selectable option (for selection, use Listbox instead).
/// </summary>
/// <example>
/// <code>
/// &lt;Menu label="Actions"&gt;
///     &lt;div role="menuitem" tabindex="-1"&gt;Cut&lt;/div&gt;
///     &lt;div role="menuitem" tabindex="-1"&gt;Copy&lt;/div&gt;
/// &lt;/Menu&gt;
/// </code>
/// </example>
public partial class Menu : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "menu" : $"menu {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "menuitem", "vertical");
    }
}
