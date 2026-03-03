using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The header section of a GanttTable, rendered as a `&lt;thead&gt;` element. Contains
/// GanttTableRow elements with column headers for task names, dates, durations, or other Gantt
/// chart metadata.
/// </summary>
/// <example>
/// <code>
/// &lt;GanttTableHead&gt;
///   &lt;GanttTableRow&gt;&lt;th&gt;Task&lt;/th&gt;&lt;th&gt;Start&lt;/th&gt;&lt;th&gt;End&lt;/th&gt;&lt;/GanttTableRow&gt;
/// &lt;/GanttTableHead&gt;
/// </code>
/// </example>
public partial class GanttTableHead : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-head" : $"gantt-table-head {CssClass}";
}
