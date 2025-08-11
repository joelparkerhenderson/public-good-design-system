using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A footnote provides supplementary information, citations, or clarifications that support the
/// main content without cluttering it. Footnotes are commonly used in articles, academic writing,
/// legal documents, and documentation to reference sources, define terms, or add context.
/// </summary>
/// <example>
/// <code>
/// &lt;Footnote id="fn1"&gt;Source: Example et al., 2024&lt;/Footnote&gt;
/// </code>
/// </example>
public partial class Footnote : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Id { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "aside" : $"aside {CssClass}";
}
