using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A breadcrumb nav is a navigation landmark that contains a breadcrumb trail showing the user's
/// current location within a site hierarchy. It renders a `&lt;nav&gt;` element with an accessible
/// label and contains a BreadcrumbNavList which holds BreadcrumbNavListItem children.
/// </summary>
/// <example>
/// <code>
/// &lt;BreadcrumbNav label="Breadcrumb"&gt;
///   &lt;BreadcrumbNavList&gt;
///     &lt;BreadcrumbNavListItem&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/BreadcrumbNavListItem&gt;
///     &lt;BreadcrumbNavListItem&gt;&lt;a href="/products"&gt;Products&lt;/a&gt;&lt;/BreadcrumbNavListItem&gt;
///     &lt;BreadcrumbNavListItem current&gt;Widget&lt;/BreadcrumbNavListItem&gt;
///   &lt;/BreadcrumbNavList&gt;
/// &lt;/BreadcrumbNav&gt;
/// </code>
/// </example>
public partial class BreadcrumbNav : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-nav" : $"breadcrumb-nav {CssClass}";
}
