using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Gantt table data cell is a single cell within a GanttTableRow representing a time period in
/// the Gantt table grid. It renders as a `&lt;td&gt;` with `role="gridcell"`. Supports an active
/// state to indicate the task spans this time period, communicated via `aria-selected` for screen
/// readers.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Active time period with bar content --&gt;
/// &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
/// 
/// &lt;!-- Inactive empty time period --&gt;
/// &lt;GanttTableData /&gt;
/// 
/// &lt;!-- Active with milestone marker --&gt;
/// &lt;GanttTableData active&gt;◆&lt;/GanttTableData&gt;
/// </code>
/// </example>
public partial class GanttTableData : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Active { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-data" : $"gantt-table-data {CssClass}";
}
