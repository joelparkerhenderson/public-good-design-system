using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A switch input is a UI/UX component that provides a binary toggle control, similar to a physical
/// on/off switch. It uses `role="switch"` with `aria-checked` to communicate the current state to
/// assistive technologies. The component supports both click and keyboard (Space key) activation
/// for accessibility compliance.
/// </summary>
/// <example>
/// <code>
/// &lt;SwitchButton label="Enable notifications" @bind-Checked /&gt;
/// </code>
/// </example>
public partial class SwitchButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Checked { get; set; }
    [Parameter] public EventCallback<bool> CheckedChanged { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "switch-button" : $"switch-button {CssClass}";

    private async Task HandleClick(MouseEventArgs args)
    {
        if (!Disabled)
        {
            Checked = !Checked;
            await CheckedChanged.InvokeAsync(Checked);
        }
    }

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == " " && !Disabled)
        {
            Checked = !Checked;
            await CheckedChanged.InvokeAsync(Checked);
        }
    }
}
