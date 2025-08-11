using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A column definition within a GanttTable, rendered as a `&lt;col&gt;` element. Used inside a
/// `&lt;colgroup&gt;` to define column properties such as span. Useful for styling entire columns
/// of the Gantt grid (e.g. weekends, milestones, or specific time periods).
/// </summary>
/// <example>
/// <code>
/// &lt;GanttTable label="Project timeline"&gt;
///   &lt;colgroup&gt;
///     &lt;GanttTableCol /&gt;
///     &lt;GanttTableCol span=@5 /&gt;
///     &lt;GanttTableCol /&gt;
///   &lt;/colgroup&gt;
///   ...
/// &lt;/GanttTable&gt;
/// </code>
/// </example>
public partial class GanttTableCol : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Span { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "gantt-table-col" : $"gantt-table-col {CssClass}";
}
