using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A display component for showing a United Kingdom National Health Service (NHS) number in a
/// read-only format. The NHS number is a 10-digit identifier that uniquely identifies individuals
/// registered with the National Health Service in England, Wales, and the Isle of Man.
/// </summary>
/// <example>
/// <code>
/// &lt;UnitedKingdomNationalHealthServiceNumberView label="NHS Number" value="123 456 7890" /&gt;
/// </code>
/// </example>
public partial class UnitedKingdomNationalHealthServiceNumberView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "united-kingdom-national-health-service-number-view" : $"united-kingdom-national-health-service-number-view {CssClass}";
}
