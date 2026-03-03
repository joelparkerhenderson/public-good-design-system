using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Net Promoter Score (NPS) rating view is a display component that presents an NPS score value
/// as read-only text. It is used to show previously captured NPS data in dashboards, reports, or
/// detail views. NPS scores range from 0 to 10, with respondents classified as Detractors (0-6),
/// Passives (7-8), or Promoters (9-10).
/// </summary>
/// <example>
/// <code>
/// &lt;NetPromoterScoreView label="NPS Score" value="8" /&gt;
/// </code>
/// </example>
public partial class NetPromoterScoreView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "net-promoter-score-view" : $"net-promoter-score-view {CssClass}";
}
