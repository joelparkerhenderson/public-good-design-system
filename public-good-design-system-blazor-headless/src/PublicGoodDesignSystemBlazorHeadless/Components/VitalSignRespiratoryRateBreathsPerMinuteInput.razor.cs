using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// VitalSignRespiratoryRateBreathsPerMinuteInput is a headless component that wraps a native
/// `&lt;input type="number"&gt;` element for entering a respiratory rate in breaths per minute,
/// with accessible labelling and sensible min, max, and step constraints. It provides
/// a bindable numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignRespiratoryRateBreathsPerMinuteInput Label="Respiratory rate (breaths/min)" @bind-Value Min=@0 Max=@100 Step=@1 /&gt;
/// </code>
/// </example>
public partial class VitalSignRespiratoryRateBreathsPerMinuteInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int? Value { get; set; }
    [Parameter] public EventCallback<int?> ValueChanged { get; set; }
    [Parameter] public int Min { get; set; } = 0;
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public int Step { get; set; } = 1;
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-respiratory-rate-breaths-per-minute-input" : $"vital-sign-respiratory-rate-breaths-per-minute-input {CssClass}";
}
