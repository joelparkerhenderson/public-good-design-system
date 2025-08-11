using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// NumberInput is a headless component that wraps a native `&lt;input type="number"&gt;` element
/// with accessible labelling and optional min, max, and step constraints. It provides a bindable
/// numeric value for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;NumberInput label="Quantity" @bind-Value min=@0 max=@100 step=@1 /&gt;
/// </code>
/// </example>
public partial class NumberInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Min { get; set; }
    [Parameter] public string? Max { get; set; }
    [Parameter] public string? Step { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "number-input" : $"number-input {CssClass}";
}
