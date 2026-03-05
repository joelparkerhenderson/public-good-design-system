using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign body fat percentage. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBodyFatPercentageView Value=@22.5 Label="Body fat: 22.5 percent" /&gt;
/// </code>
/// </example>
public partial class VitalSignBodyFatPercentageView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public double Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-body-fat-percentage-view" : $"vital-sign-body-fat-percentage-view {CssClass}";
}
