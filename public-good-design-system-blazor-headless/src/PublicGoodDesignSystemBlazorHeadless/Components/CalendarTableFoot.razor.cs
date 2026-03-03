using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The footer section of a CalendarTable, rendered as a `&lt;tfoot&gt;` element. Contains
/// CalendarTableRow elements with summary or aggregate data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTableFoot&gt;
///   &lt;CalendarTableRow&gt;
///     &lt;CalendarTableData&gt;Week Total: 5&lt;/CalendarTableData&gt;
///   &lt;/CalendarTableRow&gt;
/// &lt;/CalendarTableFoot&gt;
/// </code>
/// </example>
public partial class CalendarTableFoot : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-foot" : $"calendar-table-foot {CssClass}";
}
