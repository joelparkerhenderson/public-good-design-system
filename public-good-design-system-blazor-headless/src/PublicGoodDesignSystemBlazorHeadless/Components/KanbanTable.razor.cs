using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Kanban table organizes work items into columns representing different workflow stages such as
/// "To Do", "In Progress", and "Done". Renders as a `&lt;table&gt;` with `role="grid"` and an
/// accessible label. Supports an optional visible caption. Commonly used in project management
/// tools, agile development platforms, and task tracking applications.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTable label="Sprint 5 board"&gt;
///   &lt;KanbanTableHead&gt;
///     &lt;KanbanTableRow&gt;&lt;th&gt;To Do&lt;/th&gt;&lt;th&gt;In Progress&lt;/th&gt;&lt;th&gt;Done&lt;/th&gt;&lt;/KanbanTableRow&gt;
///   &lt;/KanbanTableHead&gt;
///   &lt;KanbanTableBody&gt;
///     &lt;KanbanTableRow&gt;
///       &lt;KanbanTableData&gt;Task A&lt;/KanbanTableData&gt;
///       &lt;KanbanTableData&gt;Task B&lt;/KanbanTableData&gt;
///       &lt;KanbanTableData&gt;Task C&lt;/KanbanTableData&gt;
///     &lt;/KanbanTableRow&gt;
///   &lt;/KanbanTableBody&gt;
/// &lt;/KanbanTable&gt;
/// </code>
/// </example>
public partial class KanbanTable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Caption { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table" : $"kanban-table {CssClass}";
}
