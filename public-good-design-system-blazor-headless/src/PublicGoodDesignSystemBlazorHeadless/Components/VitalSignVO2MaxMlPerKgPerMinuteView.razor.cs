using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign VO2 max in mL/kg/min. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignVO2MaxMlPerKgPerMinuteView Value=@42 Label="VO2 max: 42 mL/kg/min" /&gt;
/// </code>
/// </example>
public partial class VitalSignVO2MaxMlPerKgPerMinuteView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-vo2-max-ml-per-kg-per-minute-view" : $"vital-sign-vo2-max-ml-per-kg-per-minute-view {CssClass}";
}
