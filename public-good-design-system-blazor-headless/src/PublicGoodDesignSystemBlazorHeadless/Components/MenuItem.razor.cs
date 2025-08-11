using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A menu item is a UI/UX component representing a single action or option within a menu, dropdown
/// menu, or navigation menu. Menus are used throughout applications to organize and present
/// actions, settings, and navigation options in a structured, discoverable format.
/// </summary>
/// <example>
/// <code>
/// &lt;div role="menu"&gt;
///   &lt;MenuItem&gt;New File&lt;/MenuItem&gt;
///   &lt;MenuItem&gt;Open File&lt;/MenuItem&gt;
///   &lt;MenuItem&gt;Save&lt;/MenuItem&gt;
///   &lt;MenuItem&gt;Exit&lt;/MenuItem&gt;
/// &lt;/div&gt;
/// </code>
/// </example>
public partial class MenuItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "menu-item" : $"menu-item {CssClass}";
}
