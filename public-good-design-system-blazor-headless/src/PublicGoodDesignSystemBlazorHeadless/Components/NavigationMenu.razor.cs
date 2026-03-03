using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A navigation menu provides a semantic `&lt;nav&gt;` landmark with an accessible label,
/// containing navigation links or other interactive elements for site-wide or section-level
/// navigation. It enables screen reader users to quickly locate and jump to the navigation area
/// using landmark navigation, and it clearly communicates the purpose of the enclosed links.
/// </summary>
/// <example>
/// <code>
/// &lt;NavigationMenu label="Main navigation"&gt;
///     &lt;a href="/"&gt;Home&lt;/a&gt;
///     &lt;a href="/about"&gt;About&lt;/a&gt;
/// &lt;/NavigationMenu&gt;
/// </code>
/// </example>
public partial class NavigationMenu : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "navigation-menu" : $"navigation-menu {CssClass}";
}
