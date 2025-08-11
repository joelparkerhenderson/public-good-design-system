using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tab bar is a container for tab buttons using the ARIA tablist role. It provides
/// ArrowLeft/ArrowRight keyboard navigation between tabs with Home/End keys to jump to first/last
/// tabs, implementing the roving focus pattern. Each tab button controls a corresponding tabpanel.
/// </summary>
/// <example>
/// <code>
/// &lt;TabBar label="Settings"&gt;
///   &lt;TabBarButton selected={activeTab === "general"} controls="panel-general"
///     @onclick="HandleClick"&gt;General&lt;/TabBarButton&gt;
///   &lt;TabBarButton selected={activeTab === "advanced"} controls="panel-advanced"
///     @onclick="HandleClick"&gt;Advanced&lt;/TabBarButton&gt;
/// &lt;/TabBar&gt;
/// </code>
/// </example>
public partial class TabBar : ComponentBase
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
