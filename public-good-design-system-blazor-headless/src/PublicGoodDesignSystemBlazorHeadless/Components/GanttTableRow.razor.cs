using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single row within a GanttTable grid. Renders as a `&lt;tr&gt;` containing GanttTableData cells
/// for each time period and task header cells. Used inside GanttTableHead, GanttTableBody, or
/// GanttTableFoot.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Task row with active time periods --&gt;
/// &lt;GanttTableRow&gt;
///   &lt;th&gt;Development&lt;/th&gt;
///   &lt;GanttTableData /&gt;
///   &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
///   &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
/// &lt;/GanttTableRow&gt;
/// 
/// &lt;!-- Header row --&gt;
/// &lt;GanttTableRow&gt;
///   &lt;th&gt;Task&lt;/th&gt;&lt;th&gt;Week 1&lt;/th&gt;&lt;th&gt;Week 2&lt;/th&gt;&lt;th&gt;Week 3&lt;/th&gt;
/// &lt;/GanttTableRow&gt;
/// </code>
/// </example>
public partial class GanttTableRow : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-row" : $"gantt-table-row {CssClass}";
}
