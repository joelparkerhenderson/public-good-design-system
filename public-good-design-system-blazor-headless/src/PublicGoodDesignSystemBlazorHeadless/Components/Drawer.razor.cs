using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A drawer is a panel that slides in from an edge of the viewport, typically used for navigation
/// menus, filters, or supplementary content. It overlays the main content and can be dismissed by
/// the user. The component renders conditionally based on its `open` state and uses `role="dialog"`
/// with `aria-modal="true"` for proper screen reader behavior.
/// </summary>
/// <example>
/// <code>
/// &lt;Drawer label="Navigation" @bind-Open side="left"&gt;
///   &lt;nav&gt;...&lt;/nav&gt;
/// &lt;/Drawer&gt;
/// </code>
/// </example>
public partial class Drawer : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Side { get; set; } = "left";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "drawer" : $"drawer {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Open = false;
            await OpenChanged.InvokeAsync(false);
        }
    }
}
