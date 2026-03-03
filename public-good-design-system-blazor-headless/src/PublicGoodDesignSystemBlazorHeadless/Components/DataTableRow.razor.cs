using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single row within a DataTable. Renders as a `&lt;tr&gt;` containing DataTableData cells or
/// header cells. Used inside DataTableHead, DataTableBody, or DataTableFoot.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTableBody&gt;
///   &lt;DataTableRow&gt;
///     &lt;DataTableData&gt;Alice&lt;/DataTableData&gt;
///     &lt;DataTableData&gt;alice@example.com&lt;/DataTableData&gt;
///   &lt;/DataTableRow&gt;
/// &lt;/DataTableBody&gt;
/// </code>
/// </example>
public partial class DataTableRow : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-row" : $"data-table-row {CssClass}";
}
