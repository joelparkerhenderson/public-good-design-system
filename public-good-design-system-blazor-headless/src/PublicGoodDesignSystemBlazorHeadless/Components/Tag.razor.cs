using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tag is a small component used to label, categorize, or indicate the status of an item. Tags
/// are commonly used in content management systems, product listings, article metadata, and
/// filtering interfaces to visually group or classify content. They typically display short text
/// such as category names, keywords, status labels, or attribute values.
/// </summary>
/// <example>
/// <code>
/// &lt;Tag label="Category"&gt;Design&lt;/Tag&gt;
/// </code>
/// </example>
public partial class Tag : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tag" : $"tag {CssClass}";
}
