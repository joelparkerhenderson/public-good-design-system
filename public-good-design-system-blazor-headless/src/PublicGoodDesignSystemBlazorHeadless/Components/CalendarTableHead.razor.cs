using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The header section of a CalendarTable, rendered as a `&lt;thead&gt;` element. Contains
/// CalendarTableRow elements with day-of-week column headers.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTableHead&gt;
///   &lt;CalendarTableRow&gt;&lt;th&gt;Sun&lt;/th&gt;&lt;th&gt;Mon&lt;/th&gt;&lt;th&gt;Tue&lt;/th&gt;&lt;th&gt;Wed&lt;/th&gt;&lt;th&gt;Thu&lt;/th&gt;&lt;th&gt;Fri&lt;/th&gt;&lt;th&gt;Sat&lt;/th&gt;&lt;/CalendarTableRow&gt;
/// &lt;/CalendarTableHead&gt;
/// </code>
/// </example>
public partial class CalendarTableHead : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-head" : $"calendar-table-head {CssClass}";
}
