using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign body temperature in degrees Celsius. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBodyTemperatureCelciusView Value=@37.0 Label="Body temperature: 37.0 degrees Celsius" /&gt;
/// </code>
/// </example>
public partial class VitalSignBodyTemperatureCelciusView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public double Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-body-temperature-celcius-view" : $"vital-sign-body-temperature-celcius-view {CssClass}";
}
