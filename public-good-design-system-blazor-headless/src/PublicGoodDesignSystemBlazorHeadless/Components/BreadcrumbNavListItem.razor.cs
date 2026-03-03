using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A breadcrumb list item represents a single step in a breadcrumb navigation trail. It renders as
/// a semantic `&lt;li&gt;` element designed to be placed inside a BreadcrumbNavList component. The
/// component supports `aria-current="page"` to indicate when the item represents the user's current
/// location in the site hierarchy.
/// </summary>
/// <example>
/// <code>
/// &lt;BreadcrumbNavListItem&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/BreadcrumbNavListItem&gt;
/// &lt;BreadcrumbNavListItem current&gt;About&lt;/BreadcrumbNavListItem&gt;
/// </code>
/// </example>
public partial class BreadcrumbNavListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Current { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "breadcrumb-nav-list-item" : $"breadcrumb-nav-list-item {CssClass}";
}
