using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// MonthInput is a headless component that wraps a native `&lt;input type="month"&gt;` element with
/// accessible labelling for selecting a month and year. It provides a bindable value and supports
/// common form input states like required and disabled.
/// </summary>
/// <example>
/// <code>
/// &lt;MonthInput label="Start month" @bind-Value /&gt;
/// </code>
/// </example>
public partial class MonthInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "month-input" : $"month-input {CssClass}";
}
