using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A calendar range picker is a component that allows users to select a contiguous range of dates
/// by interacting with a visual calendar grid. Commonly used in booking systems, travel planners,
/// analytics dashboards, and reporting tools, the calendar range picker lets users define a start
/// date and an end date by clicking or tapping on calendar cells.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarRangePicker label="Select travel dates"&gt;
///     &lt;!-- calendar grid with date cells --&gt;
/// &lt;/CalendarRangePicker&gt;
/// </code>
/// </example>
public partial class CalendarRangePicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-range-picker" : $"calendar-range-picker {CssClass}";
}
