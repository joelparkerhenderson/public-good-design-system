using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single row within a CalendarTable grid. Renders as a `&lt;tr&gt;`, containing
/// CalendarTableData cells for each day in the week.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTable label="January 2025"&gt;
///   &lt;CalendarTableBody&gt;
///     &lt;CalendarTableRow&gt;
///       &lt;CalendarTableData&gt;1&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;2&lt;/CalendarTableData&gt;
///       &lt;CalendarTableData&gt;3&lt;/CalendarTableData&gt;
///     &lt;/CalendarTableRow&gt;
///   &lt;/CalendarTableBody&gt;
/// &lt;/CalendarTable&gt;
/// </code>
/// </example>
public partial class CalendarTableRow : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-row" : $"calendar-table-row {CssClass}";
}
