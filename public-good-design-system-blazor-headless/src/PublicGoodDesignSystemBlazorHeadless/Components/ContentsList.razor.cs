using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An ordered list for a table of contents. Renders a semantic `&lt;ol&gt;` element containing
/// ContentsListItem children. Designed to be placed inside a ContentsNav component.
/// </summary>
/// <example>
/// <code>
/// &lt;ContentsNav label="On this page"&gt;
///   &lt;ContentsList&gt;
///     &lt;ContentsListItem&gt;&lt;a href="#introduction"&gt;Introduction&lt;/a&gt;&lt;/ContentsListItem&gt;
///     &lt;ContentsListItem&gt;&lt;a href="#usage"&gt;Usage&lt;/a&gt;&lt;/ContentsListItem&gt;
///     &lt;ContentsListItem&gt;&lt;a href="#examples"&gt;Examples&lt;/a&gt;&lt;/ContentsListItem&gt;
///   &lt;/ContentsList&gt;
/// &lt;/ContentsNav&gt;
/// </code>
/// </example>
public partial class ContentsList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "contents-list" : $"contents-list {CssClass}";
}
