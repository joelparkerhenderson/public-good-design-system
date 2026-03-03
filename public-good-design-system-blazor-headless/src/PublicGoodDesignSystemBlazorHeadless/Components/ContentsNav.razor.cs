using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A contents list provides a table-of-contents-list navigation with ordered links to page
/// sections. It helps users quickly scan and jump to different parts of a long page, improving
/// navigation and content discoverability.
/// </summary>
/// <example>
/// <code>
/// &lt;ContentsNav label="Contents"&gt;
///     &lt;li&gt;&lt;a href="#introduction"&gt;Introduction&lt;/a&gt;&lt;/li&gt;
///     &lt;li&gt;&lt;a href="#usage"&gt;Usage&lt;/a&gt;&lt;/li&gt;
///     &lt;li&gt;&lt;a href="#examples"&gt;Examples&lt;/a&gt;&lt;/li&gt;
/// &lt;/ContentsNav&gt;
/// </code>
/// </example>
public partial class ContentsNav : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "contents-nav" : $"contents-nav {CssClass}";
}
