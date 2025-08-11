using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A United Kingdom National Health Service (NHS) number input is a specialized form field for
/// entering a 10-digit NHS patient identifier. The NHS number is assigned to every patient
/// registered with the National Health Service in England, Wales, and the Isle of Man, and is used
/// to uniquely identify individuals across the health system.
/// </summary>
/// <example>
/// <code>
/// &lt;UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" /&gt;
/// </code>
/// </example>
public partial class UnitedKingdomNationalHealthServiceNumberInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private string NhsPattern => "[0-9]{3} [0-9]{3} [0-9]{4}";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "united-kingdom-national-health-service-number-input" : $"united-kingdom-national-health-service-number-input {CssClass}";
}
