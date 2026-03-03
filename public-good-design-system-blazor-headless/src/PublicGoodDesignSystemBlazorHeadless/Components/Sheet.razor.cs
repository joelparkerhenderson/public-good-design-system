using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// Sheet is a headless sliding panel overlay that appears from an edge of the viewport. It
/// functions as a modal dialog with focus trapping semantics and Escape key support, commonly used
/// for navigation menus, settings panels, detail views, or filter interfaces.
/// </summary>
/// <example>
/// <code>
/// &lt;Sheet label="Settings" @bind-Open side="right"&gt;
///   &lt;p&gt;Sheet content&lt;/p&gt;
/// &lt;/Sheet&gt;
/// </code>
/// </example>
public partial class Sheet : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public string? Side { get; set; } = "right";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "sheet" : $"sheet {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Open = false;
            await OpenChanged.InvokeAsync(false);
        }
    }
}
