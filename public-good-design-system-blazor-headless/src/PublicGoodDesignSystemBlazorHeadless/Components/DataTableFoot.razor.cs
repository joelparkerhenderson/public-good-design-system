using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The footer section of a DataTable, rendered as a `&lt;tfoot&gt;` element. Contains DataTableRow
/// elements with summary or aggregate data cells.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTableFoot&gt;
///   &lt;DataTableRow&gt;
///     &lt;DataTableData&gt;Total&lt;/DataTableData&gt;
///     &lt;DataTableData&gt;$50,000&lt;/DataTableData&gt;
///   &lt;/DataTableRow&gt;
/// &lt;/DataTableFoot&gt;
/// </code>
/// </example>
public partial class DataTableFoot : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-foot" : $"data-table-foot {CssClass}";
}
