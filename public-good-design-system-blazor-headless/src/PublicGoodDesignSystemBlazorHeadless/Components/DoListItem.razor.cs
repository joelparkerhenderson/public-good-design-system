using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single recommended-practice item within a "Do" list. Renders a semantic `&lt;li&gt;` element
/// representing a guideline or best practice that users should follow. Commonly used in design
/// system documentation, style guides, and instructional content alongside `DontListItem`.
/// </summary>
/// <example>
/// <code>
/// &lt;ul aria-label="Recommended practices"&gt;
///     &lt;DoListItem&gt;Use descriptive alt text for images&lt;/DoListItem&gt;
///     &lt;DoListItem&gt;Provide visible focus indicators&lt;/DoListItem&gt;
///     &lt;DoListItem&gt;Use sufficient color contrast&lt;/DoListItem&gt;
/// &lt;/ul&gt;
/// </code>
/// </example>
public partial class DoListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "do-list-item" : $"do-list-item {CssClass}";
}
