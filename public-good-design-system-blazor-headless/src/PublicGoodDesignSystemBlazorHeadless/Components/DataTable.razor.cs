using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An interactive data table that displays structured information in rows and columns as a grid
/// widget. Renders a `&lt;table&gt;` element with `role="grid"` and an accessible label. Supports
/// an optional visible caption. Commonly used for sortable tables, editable spreadsheets, and
/// interactive data grids.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTable label="User accounts"&gt;
///   &lt;DataTableHead&gt;
///     &lt;DataTableRow&gt;&lt;th scope="col"&gt;Name&lt;/th&gt;&lt;th scope="col"&gt;Email&lt;/th&gt;&lt;/DataTableRow&gt;
///   &lt;/DataTableHead&gt;
///   &lt;DataTableBody&gt;
///     &lt;DataTableRow&gt;
///       &lt;DataTableData&gt;Alice&lt;/DataTableData&gt;
///       &lt;DataTableData&gt;alice@example.com&lt;/DataTableData&gt;
///     &lt;/DataTableRow&gt;
///   &lt;/DataTableBody&gt;
/// &lt;/DataTable&gt;
/// </code>
/// </example>
public partial class DataTable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Caption { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table" : $"data-table {CssClass}";
}
