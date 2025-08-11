using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A circular dial or knob control that allows users to adjust a numeric value within a defined
/// range. Dials provide an intuitive interaction model inspired by physical knobs found on devices
/// like volume controls, thermostats, and audio equipment. This component is useful in control
/// panels, audio applications, configuration interfaces, and anywhere a value needs fine-grained
/// adjustment.
/// </summary>
/// <example>
/// <code>
/// &lt;Dial label="Volume" @bind-Value min=@0 max=@100 /&gt;
/// </code>
/// </example>
public partial class Dial : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; } = 0;
    [Parameter] public EventCallback<int> ValueChanged { get; set; }
    [Parameter] public int Min { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public int Step { get; set; } = 1;
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "dial" : $"dial {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (Disabled) return;

        int step = Step > 0 ? Step : 1;
        int newValue = Value;

        switch (e.Key)
        {
            case "ArrowUp":
            case "ArrowRight":
                newValue = Math.Min(Value + step, Max);
                break;
            case "ArrowDown":
            case "ArrowLeft":
                newValue = Math.Max(Value - step, Min);
                break;
            case "Home":
                newValue = Min;
                break;
            case "End":
                newValue = Max;
                break;
            default:
                return;
        }

        if (newValue != Value)
        {
            Value = newValue;
            await ValueChanged.InvokeAsync(Value);
        }
    }
}
