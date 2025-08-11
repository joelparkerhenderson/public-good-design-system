using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement unit input provides a text field for entering a measurement unit, such as "kg",
/// "lb", "cm", "inch", "F", or "C". A measurement unit is a standard quantity used to express a
/// physical measurement.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementUnitInput label="Unit" @bind-Value /&gt;
/// &lt;MeasurementUnitInput label="Unit of measure" @bind-Value required /&gt;
/// </code>
/// </example>
public partial class MeasurementUnitInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-unit-input" : $"measurement-unit-input {CssClass}";
}
