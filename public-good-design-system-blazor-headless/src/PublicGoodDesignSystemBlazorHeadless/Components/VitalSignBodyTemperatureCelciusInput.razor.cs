using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// VitalSignBodyTemperatureCelciusInput is a headless component that wraps a native
/// `&lt;input type="number"&gt;` element for entering a body temperature in degrees Celsius,
/// with accessible labelling and sensible min, max, and step constraints. It provides
/// a bindable numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBodyTemperatureCelciusInput Label="Body temperature (°C)" @bind-Value Min=@30 Max=@45 Step=@0.1 /&gt;
/// </code>
/// </example>
public partial class VitalSignBodyTemperatureCelciusInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public double? Value { get; set; }
    [Parameter] public EventCallback<double?> ValueChanged { get; set; }
    [Parameter] public double Min { get; set; } = 30;
    [Parameter] public double Max { get; set; } = 45;
    [Parameter] public double Step { get; set; } = 0.1;
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-body-temperature-celcius-input" : $"vital-sign-body-temperature-celcius-input {CssClass}";
}
