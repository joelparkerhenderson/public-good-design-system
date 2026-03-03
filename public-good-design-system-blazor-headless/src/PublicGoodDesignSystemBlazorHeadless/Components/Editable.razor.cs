using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An editable component allows inline text editing. It displays a value as plain text that can be
/// clicked or activated via keyboard to enter edit mode, where it becomes an input field. Pressing
/// Enter confirms the edit, and pressing Escape cancels it, reverting to the original value.
/// </summary>
/// <example>
/// <code>
/// &lt;Editable label="Name" @bind-Value /&gt;
/// </code>
/// </example>
public partial class Editable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Editing { get; set; }
    [Parameter] public EventCallback<bool> EditingChanged { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private string Draft { get; set; } = "";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "editable" : $"editable {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Editing = false;
            await EditingChanged.InvokeAsync(false);
        }
    }
}
