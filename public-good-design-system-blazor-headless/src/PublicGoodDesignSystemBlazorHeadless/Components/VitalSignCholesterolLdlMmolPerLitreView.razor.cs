using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign cholesterol LDL level in millimoles per litre. This component
/// renders the numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignCholesterolLdlMmolPerLitreView Value=@2.5 Label="Cholesterol LDL: 2.5 mmol/L" /&gt;
/// </code>
/// </example>
public partial class VitalSignCholesterolLdlMmolPerLitreView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public double Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-cholesterol-ldl-mmol-per-litre-view" : $"vital-sign-cholesterol-ldl-mmol-per-litre-view {CssClass}";
}
