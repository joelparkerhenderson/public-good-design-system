using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A breadcrumb list is an ordered list that contains BreadcrumbNavListItem children, representing
/// the hierarchical trail in a breadcrumb navigation. It renders a semantic `&lt;ol&gt;` element to
/// convey the ordered relationship of pages in the site hierarchy.
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
public partial class BreadcrumbNavList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-nav-list" : $"breadcrumb-nav-list {CssClass}";
}
