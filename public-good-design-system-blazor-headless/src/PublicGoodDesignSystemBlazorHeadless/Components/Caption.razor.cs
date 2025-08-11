using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A caption component provides supplementary text or explanations alongside images, videos,
/// charts, or other media within an interface. It uses the semantic `&lt;figcaption&gt;` HTML
/// element, which provides an implicit association with a parent `&lt;figure&gt;` element. Captions
/// are commonly used in galleries, product pages, data visualizations, and educational content to
/// clarify or add context to visual elements.
/// </summary>
/// <example>
/// <code>
/// &lt;Caption&gt;Photo of a sunset over the ocean.&lt;/Caption&gt;
/// &lt;Caption id="chart-caption"&gt;Figure 1: Revenue growth over time.&lt;/Caption&gt;
/// </code>
/// </example>
public partial class Caption : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "caption" : $"caption {CssClass}";
}
