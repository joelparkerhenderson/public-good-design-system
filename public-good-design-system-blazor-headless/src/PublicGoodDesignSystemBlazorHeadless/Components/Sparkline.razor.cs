using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A sparkline is a compact, minimalist component used to represent trends or variations in data
/// within a small, simple graph, typically embedded within text or tables. Unlike full-scale
/// charts, sparklines display data as tiny, unadorned line, bar, or win/loss charts, offering a
/// quick at-a-glance view of patterns such as fluctuations in sales, stock prices, or performance
/// over time.
/// </summary>
/// <example>
/// <code>
/// &lt;Sparkline label="Sales trend over past 7 days"&gt;
///     &lt;svg&gt;&lt;!-- your sparkline SVG here --&gt;&lt;/svg&gt;
/// &lt;/Sparkline&gt;
/// </code>
/// </example>
public partial class Sparkline : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "sparkline" : $"sparkline {CssClass}";
}
