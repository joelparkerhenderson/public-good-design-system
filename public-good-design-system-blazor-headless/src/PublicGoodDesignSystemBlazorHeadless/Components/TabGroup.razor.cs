using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// TabBar is a headless tab list container that provides the ARIA `tablist` role and built-in
/// keyboard navigation for tab interfaces. It manages arrow key navigation between tab elements,
/// allowing users to cycle through tabs with Left/Right arrow keys, and jump to the first or last
/// tab with Home/End keys.
/// </summary>
/// <example>
/// <code>
/// &lt;TabBar label="Settings"&gt;
///   &lt;button role="tab" aria-selected="true"&gt;General&lt;/button&gt;
///   &lt;button role="tab" aria-selected="false"&gt;Advanced&lt;/button&gt;
/// &lt;/TabBar&gt;
/// </code>
/// </example>
public partial class TabGroup : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tab-bar" : $"tab-bar {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "tab", "horizontal");
    }
}
