using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A column definition within a CalendarTable, rendered as a `&lt;col&gt;` element. Used inside a
/// `&lt;colgroup&gt;` to define column properties such as span. Useful for styling entire columns
/// of the calendar grid (e.g. weekends).
/// </summary>
/// <example>
/// <code>
/// &lt;CalendarTable label="January 2025"&gt;
///   &lt;colgroup&gt;
///     &lt;CalendarTableCol /&gt;
///     &lt;CalendarTableCol span=@5 /&gt;
///     &lt;CalendarTableCol /&gt;
///   &lt;/colgroup&gt;
///   ...
/// &lt;/CalendarTable&gt;
/// </code>
/// </example>
public partial class CalendarTableCol : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Span { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "calendar-table-col" : $"calendar-table-col {CssClass}";
}
