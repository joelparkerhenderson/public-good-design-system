using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single data cell within a DataTableRow. Renders as a `&lt;td&gt;` with `role="gridcell"`.
/// Supports an active state for indicating the currently focused or selected cell, communicated via
/// `aria-selected`. Uses a roving tabindex pattern.
/// </summary>
/// <example>
/// <code>
/// &lt;DataTableRow&gt;
///   &lt;DataTableData&gt;Alice&lt;/DataTableData&gt;
///   &lt;DataTableData active&gt;Bob&lt;/DataTableData&gt;
/// &lt;/DataTableRow&gt;
/// </code>
/// </example>
public partial class DataTableData : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Active { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-table-data" : $"data-table-data {CssClass}";
}
