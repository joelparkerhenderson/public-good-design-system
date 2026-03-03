using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The footer section of a KanbanTable, rendered as a `&lt;tfoot&gt;` element. Contains
/// KanbanTableRow elements with summary or aggregate data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTableFoot&gt;
///   &lt;KanbanTableRow&gt;
///     &lt;KanbanTableData&gt;Total: 3&lt;/KanbanTableData&gt;
///     &lt;KanbanTableData&gt;Total: 5&lt;/KanbanTableData&gt;
///   &lt;/KanbanTableRow&gt;
/// &lt;/KanbanTableFoot&gt;
/// </code>
/// </example>
public partial class KanbanTableFoot : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-foot" : $"kanban-table-foot {CssClass}";
}
