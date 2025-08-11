using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A listbox presents a list of selectable options using the ARIA listbox role, with full keyboard
/// navigation support. It is used when users need to select one or more items from a visible list,
/// as opposed to a dropdown select. Common use cases include settings panels, filter selections,
/// multi-select interfaces, and any scenario where all options should be visible simultaneously.
/// </summary>
/// <example>
/// <code>
/// &lt;Listbox label="Fruits"&gt;
///     &lt;div role="option" tabindex="-1"&gt;Apple&lt;/div&gt;
///     &lt;div role="option" tabindex="-1"&gt;Banana&lt;/div&gt;
/// &lt;/Listbox&gt;
/// </code>
/// </example>
public partial class Listbox : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "listbox" : $"listbox {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "option", "vertical");
    }
}
