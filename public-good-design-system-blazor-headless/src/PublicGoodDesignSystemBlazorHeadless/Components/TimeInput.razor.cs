using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A time input provides a field for entering time values using the native HTML `&lt;input
/// type="time"&gt;` element. It renders a time picker control appropriate to the user's browser and
/// operating system, allowing users to enter hours and minutes in a localized format.
/// </summary>
/// <example>
/// <code>
/// &lt;TimeInput label="Start time" @bind-Value /&gt;
/// </code>
/// </example>
public partial class TimeInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "time-input" : $"time-input {CssClass}";
}
