using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A pagination list item represents a single entry within a pagination navigation list. It renders
/// as a semantic `&lt;li&gt;` element designed to be placed inside a PaginationList component
/// (which provides the parent `&lt;nav&gt;` and `&lt;ul&gt;` structure). The item typically
/// contains a link or button for a specific page number, previous/next controls, or an ellipsis
/// indicator.
/// </summary>
/// <example>
/// <code>
/// &lt;PaginationListItem&gt;&lt;a href="/page/1"&gt;1&lt;/a&gt;&lt;/PaginationListItem&gt;
/// </code>
/// </example>
public partial class PaginationListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "pagination-list-item" : $"pagination-list-item {CssClass}";
}
