using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A toolbar is a container for action buttons and controls using the ARIA toolbar role. It
/// provides left/right arrow key navigation between items with Home/End keys to jump to first/last
/// items, implementing the roving focus pattern for efficient keyboard interaction.
/// </summary>
/// <example>
/// <code>
/// &lt;ToolBar label="Editor tools"&gt;
///   &lt;button&gt;Bold&lt;/button&gt;
///   &lt;button&gt;Italic&lt;/button&gt;
/// &lt;/ToolBar&gt;
/// </code>
/// </example>
public partial class ToolBar : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tool-bar" : $"tool-bar {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "", "horizontal");
    }
}
