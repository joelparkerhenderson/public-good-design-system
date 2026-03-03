using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single day cell within a CalendarTable grid. Renders as a `&lt;td&gt;` with `role="gridcell"`,
/// supporting selected and today states. Uses a roving tabindex pattern where the selected cell
/// receives focus.
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTableData selected today&gt;15&lt;/CalendarTableData&gt;
/// &lt;CalendarTableData&gt;22&lt;/CalendarTableData&gt;
/// </code>
/// </example>
public partial class CalendarTableData : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Today { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-data" : $"calendar-table-data {CssClass}";
}
