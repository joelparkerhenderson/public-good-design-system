using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A datetime-local input allows users to select both a date and time using the native `&lt;input
/// type="datetime-local"&gt;` element. It provides accessible labelling via `aria-label` and a
/// bindable value for reactive form state.
/// </summary>
/// <example>
/// <code>
/// &lt;DatetimeLocalInput label="Event start" @bind-Value /&gt;
/// </code>
/// </example>
public partial class DatetimeLocalInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Min { get; set; }
    [Parameter] public string? Max { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "datetime-local-input" : $"datetime-local-input {CssClass}";
}
