using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A Kanban table column definition, rendered as a `&lt;col&gt;` element. Used inside a
/// `&lt;colgroup&gt;` to define column properties for each workflow stage.
/// </summary>
/// <example>
/// <code>
/// &lt;KanbanTable label="Board"&gt;
///   &lt;colgroup&gt;
///     &lt;KanbanTableCol span=@1 /&gt;
///     &lt;KanbanTableCol span=@1 /&gt;
///     &lt;KanbanTableCol span=@1 /&gt;
///   &lt;/colgroup&gt;
///   ...
/// &lt;/KanbanTable&gt;
/// </code>
/// </example>
public partial class KanbanTableCol : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Span { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "kanban-table-col" : $"kanban-table-col {CssClass}";
}
