using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing one Red/Orange/Yellow/Green/Blue status choice within a ROYGB status
/// picker. Renders a `&lt;button&gt;` with `aria-pressed` to indicate the selected state and
/// `data-value` for consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;RedOrangeYellowGreenBluePickerButton value="red" label="Red" selected={status === "red"} @onclick="HandleClick" /&gt;
/// &lt;RedOrangeYellowGreenBluePickerButton value="orange" label="Orange" selected={status === "orange"} @onclick="HandleClick" /&gt;
/// &lt;RedOrangeYellowGreenBluePickerButton value="yellow" label="Yellow" selected={status === "yellow"} @onclick="HandleClick" /&gt;
/// &lt;RedOrangeYellowGreenBluePickerButton value="green" label="Green" selected={status === "green"} @onclick="HandleClick" /&gt;
/// &lt;RedOrangeYellowGreenBluePickerButton value="blue" label="Blue" selected={status === "blue"} @onclick="HandleClick" /&gt;
/// </code>
/// </example>
public partial class RedOrangeYellowGreenBluePickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-orange-yellow-green-blue-picker-button" : $"red-orange-yellow-green-blue-picker-button {CssClass}";
}
