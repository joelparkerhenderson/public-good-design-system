using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A scrollbar is a UI component that allows users to navigate vertically or horizontally through
/// content that extends beyond the visible area of a container. The ScrollBar component provides a
/// headless scrollbar track element with proper ARIA scrollbar semantics, including orientation,
/// value range, and accessible labeling.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Vertical scrollbar --&gt;
/// &lt;ScrollBar orientation="vertical" label="Page scroll"&gt;
///   &lt;div&gt;&lt;!-- thumb element --&gt;&lt;/div&gt;
/// &lt;/ScrollBar&gt;
/// 
/// &lt;!-- Horizontal scrollbar --&gt;
/// &lt;ScrollBar orientation="horizontal" label="Timeline scroll"&gt;
///   &lt;div&gt;&lt;!-- thumb element --&gt;&lt;/div&gt;
/// &lt;/ScrollBar&gt;
/// </code>
/// </example>
public partial class ScrollBar : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Orientation { get; set; } = "vertical";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "scroll-bar" : $"scroll-bar {CssClass}";
}
