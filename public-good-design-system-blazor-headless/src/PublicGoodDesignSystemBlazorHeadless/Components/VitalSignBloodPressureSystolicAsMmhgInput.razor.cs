using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// VitalSignBloodPressureSystolicAsMmhgInput is a headless component that wraps a native
/// `&lt;input type="number"&gt;` element for entering a systolic blood pressure value in mmHg,
/// with accessible labelling and sensible min, max, and step constraints. It provides
/// a bindable numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignBloodPressureSystolicAsMmhgInput Label="Systolic blood pressure (mmHg)" @bind-Value Min=@0 Max=@300 Step=@1 /&gt;
/// </code>
/// </example>
public partial class VitalSignBloodPressureSystolicAsMmhgInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int? Value { get; set; }
    [Parameter] public EventCallback<int?> ValueChanged { get; set; }
    [Parameter] public int Min { get; set; } = 0;
    [Parameter] public int Max { get; set; } = 300;
    [Parameter] public int Step { get; set; } = 1;
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-blood-pressure-systolic-as-mmhg-input" : $"vital-sign-blood-pressure-systolic-as-mmhg-input {CssClass}";
}
