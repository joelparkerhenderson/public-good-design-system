using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An interactive calendar table that presents dates in a structured grid layout, typically
/// organized by weeks and days, allowing users to view and interact with calendar data at a glance.
/// Renders a `&lt;table&gt;` element with `role="grid"` and an accessible label. Supports an
/// optional visible caption.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTable label="January 2025"&gt;
///   &lt;CalendarTableHead&gt;
///     &lt;CalendarTableRow&gt;&lt;th&gt;Sun&lt;/th&gt;&lt;th&gt;Mon&lt;/th&gt;&lt;th&gt;Tue&lt;/th&gt;&lt;th&gt;Wed&lt;/th&gt;&lt;th&gt;Thu&lt;/th&gt;&lt;th&gt;Fri&lt;/th&gt;&lt;th&gt;Sat&lt;/th&gt;&lt;/CalendarTableRow&gt;
///   &lt;/CalendarTableHead&gt;
///   &lt;CalendarTableBody&gt;
///     &lt;CalendarTableRow&gt;
///       &lt;CalendarTableData&gt;1&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;2&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;3&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;4&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;5&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;6&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;7&lt;/CalendarTableData&gt;
///     &lt;/CalendarTableRow&gt;
///   &lt;/CalendarTableBody&gt;
/// &lt;/CalendarTable&gt;
/// </code>
/// </example>
public partial class CalendarTable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Caption { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table" : $"calendar-table {CssClass}";
}
