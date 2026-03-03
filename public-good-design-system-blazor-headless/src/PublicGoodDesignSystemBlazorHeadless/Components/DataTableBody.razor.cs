using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The body section of a DataTable, rendered as a `&lt;tbody&gt;` element. Contains DataTableRow
/// elements with data cells.
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
public partial class DataTableBody : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-body" : $"data-table-body {CssClass}";
}
