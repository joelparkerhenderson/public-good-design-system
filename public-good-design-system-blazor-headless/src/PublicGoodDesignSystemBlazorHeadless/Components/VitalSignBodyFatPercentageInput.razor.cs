using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// VitalSignBodyFatPercentageInput is a headless component that wraps a native
/// `&lt;input type="number"&gt;` element for entering a body fat percentage,
/// with accessible labelling and sensible min, max, and step constraints. It provides
/// a bindable numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBodyFatPercentageInput Label="Body fat (%)" @bind-Value Min=@0 Max=@100 Step=@0.1 /&gt;
/// </code>
/// </example>
public partial class VitalSignBodyFatPercentageInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public double? Value { get; set; }
    [Parameter] public EventCallback<double?> ValueChanged { get; set; }
    [Parameter] public double Min { get; set; } = 0;
    [Parameter] public double Max { get; set; } = 100;
    [Parameter] public double Step { get; set; } = 0.1;
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-body-fat-percentage-input" : $"vital-sign-body-fat-percentage-input {CssClass}";
}
