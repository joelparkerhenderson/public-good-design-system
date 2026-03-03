using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// Sidebar is a headless complementary region that uses the semantic `&lt;aside&gt;` element. It
/// provides a labeled landmark for content that is tangentially related to the main content, such
/// as navigation menus, filters, related links, or supplementary information.
/// </summary>
/// <example>
/// <code>
/// &lt;Sidebar label="Navigation"&gt;
///   &lt;nav&gt;...&lt;/nav&gt;
/// &lt;/Sidebar&gt;
/// </code>
/// </example>
public partial class Sidebar : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "sidebar" : $"sidebar {CssClass}";
}
