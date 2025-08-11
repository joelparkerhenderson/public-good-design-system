using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A timeline list item is a single event entry within a TimelineList. It renders a semantic
/// `&lt;li&gt;` element with an optional `&lt;time&gt;` element for machine-readable dates and a
/// heading for the visible date text, followed by descriptive content provided through the children
/// snippet.
/// </summary>
/// <example>
/// <code>
/// &lt;TimelineList label="Order history"&gt;
///   &lt;TimelineListItem datetime="2024-01-15" heading="January 15, 2024"&gt;
///     Order placed
///   &lt;/TimelineListItem&gt;
///   &lt;TimelineListItem datetime="2024-01-16" heading="January 16, 2024"&gt;
///     Order shipped
///   &lt;/TimelineListItem&gt;
///   &lt;TimelineListItem datetime="2024-01-19" heading="January 19, 2024"&gt;
///     Order delivered
///   &lt;/TimelineListItem&gt;
/// &lt;/TimelineList&gt;
/// </code>
/// </example>
public partial class TimelineListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Datetime { get; set; }
    [Parameter] public string? Heading { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "timeline-list-item" : $"timeline-list-item {CssClass}";
}
