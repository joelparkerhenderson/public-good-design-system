using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tool bar button is a single button within a toolbar, rendered as a native `&lt;button&gt;`
/// element for proper keyboard and screen reader support. It is designed to be placed inside a
/// ToolBar container that manages roving focus keyboard navigation.
/// </summary>
/// <example>
/// <code>
/// &lt;ToolBar label="Editor tools"&gt;
///   &lt;ToolBarButton&gt;Bold&lt;/ToolBarButton&gt;
///   &lt;ToolBarButton&gt;Italic&lt;/ToolBarButton&gt;
///   &lt;ToolBarButton disabled&gt;Redo&lt;/ToolBarButton&gt;
/// &lt;/ToolBar&gt;
/// </code>
/// </example>
public partial class ToolBarButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tool-bar-button" : $"tool-bar-button {CssClass}";
}
