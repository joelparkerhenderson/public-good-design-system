using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The header section of a KanbanTable, rendered as a `&lt;thead&gt;` element. Contains
/// KanbanTableRow elements with column headers for workflow stages.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTableHead&gt;
///   &lt;KanbanTableRow&gt;&lt;th&gt;To Do&lt;/th&gt;&lt;th&gt;In Progress&lt;/th&gt;&lt;th&gt;Done&lt;/th&gt;&lt;/KanbanTableRow&gt;
/// &lt;/KanbanTableHead&gt;
/// </code>
/// </example>
public partial class KanbanTableHead : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-head" : $"kanban-table-head {CssClass}";
}
