using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Kanban table row is a single row within a KanbanTable grid. Renders as a `&lt;tr&gt;`
/// containing KanbanTableData cells for each workflow column.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTableRow&gt;
///   &lt;KanbanTableData&gt;Task A&lt;/KanbanTableData&gt;
///   &lt;KanbanTableData&gt;Task B&lt;/KanbanTableData&gt;
/// &lt;/KanbanTableRow&gt;
/// </code>
/// </example>
public partial class KanbanTableRow : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-row" : $"kanban-table-row {CssClass}";
}
