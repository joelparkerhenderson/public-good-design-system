using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A 2D area selector for choosing colors by saturation (X axis) and brightness (Y axis). Users
/// navigate the board with keyboard arrow keys, with Shift held for larger steps. The component
/// exposes `data-x` and `data-y` attributes for CSS-based cursor positioning, enabling consumers to
/// render a visual indicator at the selected coordinates.
/// </summary>
/// <example>
/// <code>
/// &lt;ColorPicker label="Color saturation and brightness" @bind-X @bind-Y /&gt;
/// </code>
/// </example>
public partial class ColorPicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int X { get; set; } = 0;
    [Parameter] public EventCallback<int> XChanged { get; set; }
    [Parameter] public int Y { get; set; } = 0;
    [Parameter] public EventCallback<int> YChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "color-picker" : $"color-picker {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (Disabled) return;

        int step = e.ShiftKey ? 10 : 1;
        int newX = X;
        int newY = Y;

        switch (e.Key)
        {
            case "ArrowRight":
                newX = Math.Min(X + step, 100);
                break;
            case "ArrowLeft":
                newX = Math.Max(X - step, 0);
                break;
            case "ArrowUp":
                newY = Math.Max(Y - step, 0);
                break;
            case "ArrowDown":
                newY = Math.Min(Y + step, 100);
                break;
            default:
                return;
        }

        if (newX != X)
        {
            X = newX;
            await XChanged.InvokeAsync(X);
        }
        if (newY != Y)
        {
            Y = newY;
            await YChanged.InvokeAsync(Y);
        }
    }
}
