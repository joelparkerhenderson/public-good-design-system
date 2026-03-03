using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A pagination nav is a navigation landmark that contains pagination controls for navigating
/// between pages of content. It renders a `&lt;nav&gt;` element with an accessible label and
/// contains a PaginationList which holds PaginationListItem children.
/// </summary>
/// <example>
/// <code>
/// &lt;PaginationNav label="Pagination"&gt;
///   &lt;PaginationList&gt;
///     &lt;PaginationListItem&gt;&lt;a href="/page/1"&gt;Previous&lt;/a&gt;&lt;/PaginationListItem&gt;
///     &lt;PaginationListItem&gt;&lt;a href="/page/1"&gt;1&lt;/a&gt;&lt;/PaginationListItem&gt;
///     &lt;PaginationListItem&gt;&lt;a href="/page/2" aria-current="page"&gt;2&lt;/a&gt;&lt;/PaginationListItem&gt;
///     &lt;PaginationListItem&gt;&lt;a href="/page/3"&gt;3&lt;/a&gt;&lt;/PaginationListItem&gt;
///     &lt;PaginationListItem&gt;&lt;a href="/page/3"&gt;Next&lt;/a&gt;&lt;/PaginationListItem&gt;
///   &lt;/PaginationList&gt;
/// &lt;/PaginationNav&gt;
/// </code>
/// </example>
public partial class PaginationNav : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "pagination-nav" : $"pagination-nav {CssClass}";
}
