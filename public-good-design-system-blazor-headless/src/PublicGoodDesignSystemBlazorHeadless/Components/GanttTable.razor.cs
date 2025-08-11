using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An interactive Gantt table that displays project tasks and their timelines as a structured grid
/// widget. Renders a `&lt;table&gt;` element with `role="grid"` and an accessible label. Supports
/// an optional visible caption. Commonly used in project management tools and resource planning
/// applications.
/// </summary>
/// <example>
/// <code>
/// &lt;GanttTable label="Project Alpha timeline"&gt;
///   &lt;GanttTableHead&gt;
///     &lt;GanttTableRow&gt;
///       &lt;th&gt;Task&lt;/th&gt;&lt;th&gt;Week 1&lt;/th&gt;&lt;th&gt;Week 2&lt;/th&gt;&lt;th&gt;Week 3&lt;/th&gt;
///     &lt;/GanttTableRow&gt;
///   &lt;/GanttTableHead&gt;
///   &lt;GanttTableBody&gt;
///     &lt;GanttTableRow&gt;
///       &lt;th&gt;Design&lt;/th&gt;
///       &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
///       &lt;GanttTableData /&gt;
///       &lt;GanttTableData /&gt;
///     &lt;/GanttTableRow&gt;
///     &lt;GanttTableRow&gt;
///       &lt;th&gt;Development&lt;/th&gt;
///       &lt;GanttTableData /&gt;
///       &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
///       &lt;GanttTableData active&gt;---&lt;/GanttTableData&gt;
///     &lt;/GanttTableRow&gt;
///   &lt;/GanttTableBody&gt;
/// &lt;/GanttTable&gt;
/// </code>
/// </example>
public partial class GanttTable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Caption { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table" : $"gantt-table {CssClass}";
}
