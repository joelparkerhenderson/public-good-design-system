using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign blood pressure systolic value in mmHg. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBloodPressureSystolicAsMmhgView Value=@120 Label="Systolic blood pressure: 120 mmHg" /&gt;
/// </code>
/// </example>
public partial class VitalSignBloodPressureSystolicAsMmhgView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-blood-pressure-systolic-as-mmhg-view" : $"vital-sign-blood-pressure-systolic-as-mmhg-view {CssClass}";
}
