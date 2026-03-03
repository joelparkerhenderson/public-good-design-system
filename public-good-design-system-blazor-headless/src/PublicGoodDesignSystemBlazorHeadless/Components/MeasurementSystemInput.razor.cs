using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement system input provides a text field for entering a measurement system name, such as
/// "metric", "imperial", or "SI". A measurement system is a collection of units and rules for
/// measuring physical quantities.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementSystemInput label="Measurement system" @bind-Value /&gt;
/// &lt;MeasurementSystemInput label="System" @bind-Value required /&gt;
/// </code>
/// </example>
public partial class MeasurementSystemInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-system-input" : $"measurement-system-input {CssClass}";
}
