using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The body section of a CalendarTable, rendered as a `&lt;tbody&gt;` element. Contains
/// CalendarTableRow elements with day data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTableBody&gt;
///   &lt;CalendarTableRow&gt;
///     &lt;CalendarTableData&gt;1&lt;/CalendarTableData&gt;
///     &lt;CalendarTableData&gt;2&lt;/CalendarTableData&gt;
///   &lt;/CalendarTableRow&gt;
/// &lt;/CalendarTableBody&gt;
/// </code>
/// </example>
public partial class CalendarTableBody : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-body" : $"calendar-table-body {CssClass}";
}
