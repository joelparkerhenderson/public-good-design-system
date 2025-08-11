using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The footer section of a GanttTable, rendered as a `&lt;tfoot&gt;` element. Contains
/// GanttTableRow elements with summary or aggregate data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;GanttTableFoot&gt;
///   &lt;GanttTableRow&gt;
///     &lt;GanttTableData&gt;Total: 12 tasks&lt;/GanttTableData&gt;
///   &lt;/GanttTableRow&gt;
/// &lt;/GanttTableFoot&gt;
/// </code>
/// </example>
public partial class GanttTableFoot : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-foot" : $"gantt-table-foot {CssClass}";
}
