using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Net Promoter Score (NPS) rating input that allows users to select a score from 0 to 10,
/// representing their likelihood to recommend a product, service, or organization. It is a widely
/// used customer loyalty metric developed by Fred Reichheld and Bain &amp; Company. The component
/// renders as a fieldset with a radiogroup role containing 11 radio buttons, one for each score
/// value. Scores are typically categorized as Detractors (0-6), Passives (7-8), and Promoters
/// (9-10). This headless component provides the semantic structure and accessibility features while
/// allowing consumers to apply their own visual styling.
/// </summary>
/// <example>
/// <code>
/// &lt;NetPromoterScorePicker label="How likely are you to recommend us?" @bind-Value="score" /&gt;
/// &lt;p&gt;Selected score: @score&lt;/p&gt;
/// </code>
/// </example>
public partial class NetPromoterScorePicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Name { get; set; } = "nps";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "net-promoter-score-picker" : $"net-promoter-score-picker {CssClass}";
}
