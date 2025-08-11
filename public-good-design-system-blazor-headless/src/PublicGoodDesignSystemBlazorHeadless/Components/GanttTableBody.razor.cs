using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The body section of a GanttTable, rendered as a `&lt;tbody&gt;` element. Contains GanttTableRow
/// elements with task data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;GanttTableBody&gt;
///   &lt;GanttTableRow&gt;
///     &lt;GanttTableData&gt;Design&lt;/GanttTableData&gt;
///     &lt;GanttTableData&gt;Jan 1&lt;/GanttTableData&gt;
///   &lt;/GanttTableRow&gt;
/// &lt;/GanttTableBody&gt;
/// </code>
/// </example>
public partial class GanttTableBody : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-body" : $"gantt-table-body {CssClass}";
}
