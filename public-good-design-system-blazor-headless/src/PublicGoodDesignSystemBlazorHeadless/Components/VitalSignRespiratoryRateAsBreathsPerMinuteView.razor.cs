using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign respiratory rate in breaths per minute. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignRespiratoryRateAsBreathsPerMinuteView Value=@16 Label="Respiratory rate: 16 breaths per minute" /&gt;
/// </code>
/// </example>
public partial class VitalSignRespiratoryRateAsBreathsPerMinuteView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-respiratory-rate-as-breaths-per-minute-view" : $"vital-sign-respiratory-rate-as-breaths-per-minute-view {CssClass}";
}
