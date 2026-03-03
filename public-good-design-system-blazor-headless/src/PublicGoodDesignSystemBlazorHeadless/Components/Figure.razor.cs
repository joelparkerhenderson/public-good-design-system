using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A figure is a component used to visually represent data through graphical formats such as bar
/// figures, line figures, pie figures, area figures, and scatter plots. Commonly used in
/// dashboards, reports, analytics tools, and data-driven applications, figures transform raw
/// numbers into visual patterns that make trends, comparisons, and distributions easier to
/// understand at a glance.
/// </summary>
/// <example>
/// <code>
/// &lt;Figure label="Monthly revenue for 2024"&gt;
///     &lt;svg&gt;&lt;!-- bar figure SVG here --&gt;&lt;/svg&gt;
/// &lt;/Figure&gt;
/// </code>
/// </example>
public partial class Figure : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "figure" : $"figure {CssClass}";
}
