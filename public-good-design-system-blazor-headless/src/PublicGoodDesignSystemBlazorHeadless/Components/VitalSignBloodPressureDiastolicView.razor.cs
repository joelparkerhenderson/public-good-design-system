using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign blood pressure diastolic value in mmHg. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBloodPressureDiastolicView Value=@80 Label="Diastolic blood pressure: 80 mmHg" /&gt;
/// </code>
/// </example>
public partial class VitalSignBloodPressureDiastolicView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-blood-pressure-diastolic-view" : $"vital-sign-blood-pressure-diastolic-view {CssClass}";
}
