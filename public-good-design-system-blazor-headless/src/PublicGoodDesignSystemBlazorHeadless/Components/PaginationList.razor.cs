using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A pagination list is a navigation component that divides content into separate pages, allowing
/// users to navigate through large sets of data or information one section at a time. The
/// PaginationList component provides a headless wrapper using the semantic `&lt;nav&gt;` and
/// `&lt;ul&gt;` elements, with an accessible label to identify the navigation purpose.
/// </summary>
/// <example>
/// <code>
/// &lt;PaginationList label="Pagination"&gt;
///   &lt;li&gt;&lt;a href="/page/1"&gt;1&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/2" aria-current="page"&gt;2&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/3"&gt;3&lt;/a&gt;&lt;/li&gt;
/// &lt;/PaginationList&gt;
/// 
/// &lt;!-- With previous/next controls --&gt;
/// &lt;PaginationList label="Search results pages"&gt;
///   &lt;li&gt;&lt;a href="/page/1"&gt;Previous&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/1"&gt;1&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/2" aria-current="page"&gt;2&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/3"&gt;3&lt;/a&gt;&lt;/li&gt;
///   &lt;li&gt;&lt;a href="/page/3"&gt;Next&lt;/a&gt;&lt;/li&gt;
/// &lt;/PaginationList&gt;
/// </code>
/// </example>
public partial class PaginationList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "pagination-list" : $"pagination-list {CssClass}";
}
