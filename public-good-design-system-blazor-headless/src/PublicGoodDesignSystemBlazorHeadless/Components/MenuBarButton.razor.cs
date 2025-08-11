using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A menu bar button is a single interactive item within a menu bar, using the ARIA menuitem role
/// for keyboard navigation and screen reader support. It renders as a `&lt;button&gt;` with
/// `role="menuitem"` and `tabindex="-1"`, designed to be placed inside a MenuBar container with
/// `role="menubar"`.
/// </summary>
/// <example>
/// <code>
/// &lt;MenuBar label="Main menu"&gt;
///   &lt;MenuBarButton&gt;File&lt;/MenuBarButton&gt;
///   &lt;MenuBarButton&gt;Edit&lt;/MenuBarButton&gt;
///   &lt;MenuBarButton&gt;View&lt;/MenuBarButton&gt;
/// &lt;/MenuBar&gt;
/// </code>
/// </example>
public partial class MenuBarButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "menu-bar-button" : $"menu-bar-button {CssClass}";
}
