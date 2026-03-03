using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A context menu item is a UI/UX component representing a single action or option within a context
/// menu (also known as a right-click menu). Context menus appear in response to a secondary
/// interaction (typically right-click on desktop or long-press on mobile) and provide contextually
/// relevant actions for the element that was interacted with.
/// </summary>
/// <example>
/// <code>
/// &lt;ContextMenuItem&gt;Cut&lt;/ContextMenuItem&gt;
/// &lt;ContextMenuItem&gt;Copy&lt;/ContextMenuItem&gt;
/// &lt;ContextMenuItem&gt;Paste&lt;/ContextMenuItem&gt;
/// &lt;ContextMenuItem disabled&gt;Delete&lt;/ContextMenuItem&gt;
/// </code>
/// </example>
public partial class ContextMenuItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "context-menu-item" : $"context-menu-item {CssClass}";
}
