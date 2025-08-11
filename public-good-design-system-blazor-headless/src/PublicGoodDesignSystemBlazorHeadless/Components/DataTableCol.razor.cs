using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A column definition within a DataTable, rendered as a `&lt;col&gt;` element. Used inside a
/// `&lt;colgroup&gt;` to define column properties such as span. Useful for styling entire columns
/// of the data table.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTable label="Users"&gt;
///   &lt;colgroup&gt;
///     &lt;DataTableCol /&gt;
///     &lt;DataTableCol span=@3 /&gt;
///   &lt;/colgroup&gt;
///   ...
/// &lt;/DataTable&gt;
/// </code>
/// </example>
public partial class DataTableCol : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Span { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-col" : $"data-table-col {CssClass}";
}
