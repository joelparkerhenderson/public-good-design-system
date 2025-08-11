using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A timeline list is a UI/UX component used to visually organize and display events, steps, or
/// data points in chronological order, helping users understand progression over time. Commonly
/// used in project tracking, activity feeds, historical overviews, or user journeys, timelines can
/// be vertical, horizontal, or interactive, often incorporating icons, dates, and brief
/// descriptions for clarity. This component aids comprehension by making complex sequences more
/// intuitive and scannable. Effective timeline design emphasizes readability, logical flow, and
/// visual hierarchy, allowing users to quickly grasp the order, timing, and significance of events
/// or stages.
/// </summary>
/// <example>
/// <code>
/// &lt;TimelineList label="Project milestones"&gt;
///   &lt;TimelineListItem datetime="2024-01" heading="Jan 2024"&gt;Project kickoff&lt;/TimelineListItem&gt;
///   &lt;TimelineListItem datetime="2024-03" heading="Mar 2024"&gt;Alpha release&lt;/TimelineListItem&gt;
///   &lt;TimelineListItem datetime="2024-06" heading="Jun 2024"&gt;Beta release&lt;/TimelineListItem&gt;
///   &lt;TimelineListItem datetime="2024-09" heading="Sep 2024"&gt;General availability&lt;/TimelineListItem&gt;
/// &lt;/TimelineList&gt;
/// </code>
/// </example>
public partial class TimelineList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "timeline-list" : $"timeline-list {CssClass}";
}
