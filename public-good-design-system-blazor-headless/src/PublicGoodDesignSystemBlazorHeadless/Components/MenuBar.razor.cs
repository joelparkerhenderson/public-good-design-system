using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A menu bar is a horizontal menu container using the ARIA menubar role, typically found at the
/// top of an application window. It provides ArrowLeft/ArrowRight keyboard navigation between menu
/// items with Home/End keys to jump to first/last items, implementing the roving focus pattern.
/// Each top-level item may open a submenu or trigger an action.
/// </summary>
/// <example>
/// <code>
/// &lt;MenuBar label="Main menu"&gt;
///   &lt;MenuBarButton&gt;File&lt;/MenuBarButton&gt;
///   &lt;MenuBarButton&gt;Edit&lt;/MenuBarButton&gt;
///   &lt;MenuBarButton&gt;View&lt;/MenuBarButton&gt;
/// &lt;/MenuBar&gt;
/// </code>
/// </example>
public partial class MenuBar : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "menu-bar" : $"menu-bar {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "menuitem", "horizontal");
    }
}
