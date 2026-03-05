using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// VitalSignCholesterolLdlMmolPerLitreInput is a headless component that wraps a native
/// `&lt;input type="number"&gt;` element for entering a cholesterol LDL level in millimoles per litre,
/// with accessible labelling and sensible min, max, and step constraints. It provides
/// a bindable numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignCholesterolLdlMmolPerLitreInput Label="Cholesterol LDL (mmol/L)" @bind-Value Min=@0 Max=@10 Step=@0.1 /&gt;
/// </code>
/// </example>
public partial class VitalSignCholesterolLdlMmolPerLitreInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public double? Value { get; set; }
    [Parameter] public EventCallback<double?> ValueChanged { get; set; }
    [Parameter] public double Min { get; set; } = 0;
    [Parameter] public double Max { get; set; } = 10;
    [Parameter] public double Step { get; set; } = 0.1;
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-cholesterol-ldl-mmol-per-litre-input" : $"vital-sign-cholesterol-ldl-mmol-per-litre-input {CssClass}";
}
