using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing one Red/Amber/Green status choice within a RAG status picker. Renders a
/// `&lt;button&gt;` with `aria-pressed` to indicate the selected state and `data-value` for
/// consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;RedAmberGreenPickerButton value="red" label="Red" selected={status === "red"} @onclick="HandleClick" /&gt;
/// &lt;RedAmberGreenPickerButton value="amber" label="Amber" selected={status === "amber"} @onclick="HandleClick" /&gt;
/// &lt;RedAmberGreenPickerButton value="green" label="Green" selected={status === "green"} @onclick="HandleClick" /&gt;
/// </code>
/// </example>
public partial class RedAmberGreenPickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-amber-green-picker-button" : $"red-amber-green-picker-button {CssClass}";
}
