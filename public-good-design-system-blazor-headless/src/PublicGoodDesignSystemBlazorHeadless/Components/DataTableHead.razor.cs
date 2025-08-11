using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The header section of a DataTable, rendered as a `&lt;thead&gt;` element. Contains DataTableRow
/// elements with column header cells.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTableHead&gt;
///   &lt;DataTableRow&gt;&lt;th scope="col"&gt;Name&lt;/th&gt;&lt;th scope="col"&gt;Email&lt;/th&gt;&lt;/DataTableRow&gt;
/// &lt;/DataTableHead&gt;
/// </code>
/// </example>
public partial class DataTableHead : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-head" : $"data-table-head {CssClass}";
}
