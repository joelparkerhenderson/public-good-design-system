using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single discouraged-practice item within a "Don't" list. Renders a semantic `&lt;li&gt;`
/// element representing a guideline or practice that users should avoid. Commonly used in design
/// system documentation, style guides, and instructional content alongside `DoListItem`.
/// </summary>
/// <example>
/// <code>
/// &lt;ul aria-label="Practices to avoid"&gt;
///     &lt;DontListItem&gt;Use color alone to convey meaning&lt;/DontListItem&gt;
///     &lt;DontListItem&gt;Remove focus outlines without replacement&lt;/DontListItem&gt;
///     &lt;DontListItem&gt;Rely solely on placeholder text as labels&lt;/DontListItem&gt;
/// &lt;/ul&gt;
/// </code>
/// </example>
public partial class DontListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "dont-list-item" : $"dont-list-item {CssClass}";
}
