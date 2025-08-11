using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A toggle is a UI/UX component that provides a binary on/off control using a button with
/// `role="switch"`. It communicates its state through `aria-checked` and supports both click and
/// keyboard (Space key) interaction. The pressed state is bindable for two-way data flow.
/// </summary>
/// <example>
/// <code>
/// &lt;ToggleButton label="Dark mode" @bind-Pressed /&gt;
/// </code>
/// </example>
public partial class ToggleButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Pressed { get; set; }
    [Parameter] public EventCallback<bool> PressedChanged { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "toggle-button" : $"toggle-button {CssClass}";

    private async Task HandleClick(MouseEventArgs args)
    {
        if (!Disabled)
        {
            Pressed = !Pressed;
            await PressedChanged.InvokeAsync(Pressed);
        }
    }

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == " " && !Disabled)
        {
            Pressed = !Pressed;
            await PressedChanged.InvokeAsync(Pressed);
        }
    }
}
