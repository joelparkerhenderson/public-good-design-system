using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Kanban table data cell is a single cell within a KanbanTableRow, rendered as a `&lt;td&gt;`
/// with `role="gridcell"`. Represents a task card or content area within a workflow column.
/// Supports an active state with `aria-selected` and roving tabindex for keyboard navigation.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTableRow&gt;
///   &lt;KanbanTableData active label="Fix login bug"&gt;Fix login bug&lt;/KanbanTableData&gt;
///   &lt;KanbanTableData /&gt;
///   &lt;KanbanTableData /&gt;
/// &lt;/KanbanTableRow&gt;
/// </code>
/// </example>
public partial class KanbanTableData : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Active { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-data" : $"kanban-table-data {CssClass}";
}
