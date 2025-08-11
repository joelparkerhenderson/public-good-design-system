using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign waist circumference in centimeters. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignWaistCircumferenceAsCmView Value=@94 Label="94 cm waist circumference" /&gt;
/// </code>
/// </example>
public partial class VitalSignWaistCircumferenceAsCmView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-waist-circumference-as-cm-view" : $"vital-sign-waist-circumference-as-cm-view {CssClass}";
}
