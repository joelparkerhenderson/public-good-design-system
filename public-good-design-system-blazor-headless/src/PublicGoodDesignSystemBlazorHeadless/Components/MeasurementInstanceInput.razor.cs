using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement instance input provides a text field for entering a specific measurement value,
/// such as "72 kg", "98.6 F", or "120/80 mmHg". A measurement instance represents an individual
/// recorded measurement with both its numeric value and unit.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementInstanceInput label="Weight" @bind-Value /&gt;
/// &lt;MeasurementInstanceInput label="Temperature" @bind-Value required /&gt;
/// </code>
/// </example>
public partial class MeasurementInstanceInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-instance-input" : $"measurement-instance-input {CssClass}";
}
