using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A modal or non-modal dialog that overlays the main interface to communicate information or
/// prompt users for input. Dialogs are used for confirmations, alerts, forms, settings, and any
/// interaction that requires focused user attention. Modal dialogs block interaction with the
/// underlying page until dismissed, while non-modal dialogs allow background interaction.
/// </summary>
/// <example>
/// <code>
/// &lt;button @onclick="HandleClick"&gt;Open Dialog&lt;/button&gt;
/// 
/// &lt;Dialog label="Confirm action" @bind-Open="showDialog"&gt;
///   &lt;p&gt;Are you sure you want to proceed?&lt;/p&gt;
///   &lt;button @onclick="HandleClick"&gt;Cancel&lt;/button&gt;
///   &lt;button @onclick="HandleClick"}&gt;Confirm&lt;/button&gt;
/// &lt;/Dialog&gt;
/// </code>
/// </example>
public partial class Dialog : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Modal { get; set; } = true;
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "dialog" : $"dialog {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Open = false;
            await OpenChanged.InvokeAsync(false);
        }
    }
}
