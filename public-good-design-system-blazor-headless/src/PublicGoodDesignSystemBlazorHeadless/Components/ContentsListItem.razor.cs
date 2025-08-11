using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A contents list item is a single entry within a table of contents or navigation list. It renders
/// as a semantic list item (`&lt;li&gt;`) that typically contains a link to a section of a page or
/// document.
/// </summary>
/// <example>
/// <code>
/// &lt;ContentsListItem&gt;&lt;a href="#section-1"&gt;Introduction&lt;/a&gt;&lt;/ContentsListItem&gt;
/// &lt;ContentsListItem&gt;&lt;a href="#section-2"&gt;Methods&lt;/a&gt;&lt;/ContentsListItem&gt;
/// &lt;ContentsListItem&gt;
///   &lt;a href="#section-3"&gt;Results&lt;/a&gt;
///   &lt;ul&gt;
///     &lt;ContentsListItem&gt;&lt;a href="#section-3a"&gt;Data&lt;/a&gt;&lt;/ContentsListItem&gt;
///     &lt;ContentsListItem&gt;&lt;a href="#section-3b"&gt;Analysis&lt;/a&gt;&lt;/ContentsListItem&gt;
///   &lt;/ul&gt;
/// &lt;/ContentsListItem&gt;
/// </code>
/// </example>
public partial class ContentsListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "contents-list-item" : $"contents-list-item {CssClass}";
}
