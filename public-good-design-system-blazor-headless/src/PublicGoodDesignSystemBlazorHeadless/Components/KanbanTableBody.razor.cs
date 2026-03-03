using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The body section of a KanbanTable, rendered as a `&lt;tbody&gt;` element. Contains
/// KanbanTableRow elements with task data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTableBody&gt;
///   &lt;KanbanTableRow&gt;
///     &lt;KanbanTableData&gt;Task A&lt;/KanbanTableData&gt;
///     &lt;KanbanTableData&gt;Task B&lt;/KanbanTableData&gt;
///   &lt;/KanbanTableRow&gt;
/// &lt;/KanbanTableBody&gt;
/// </code>
/// </example>
public partial class KanbanTableBody : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-body" : $"kanban-table-body {CssClass}";
}
