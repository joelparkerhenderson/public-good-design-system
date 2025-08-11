using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A date range is a component that provides paired start and end date inputs, allowing users to
/// specify a span of time. Commonly used in booking forms, search filters, reporting interfaces,
/// and scheduling tools, the date range component groups two date inputs together with a shared
/// label to communicate that they represent a related pair.
/// </summary>
/// <example>
/// <code>
/// &lt;DateRange
///     label="Trip dates"
///     startLabel="Departure"
///     endLabel="Return"
///     @bind-Start
///     @bind-End
/// /&gt;
/// </code>
/// </example>
public partial class DateRange : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string StartLabel { get; set; } = "";
    [Parameter] public string EndLabel { get; set; } = "";
    [Parameter] public string? Start { get; set; } = "";
    [Parameter] public EventCallback<string> StartChanged { get; set; }
    [Parameter] public string? End { get; set; } = "";
    [Parameter] public EventCallback<string> EndChanged { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "date-range" : $"date-range {CssClass}";
}
