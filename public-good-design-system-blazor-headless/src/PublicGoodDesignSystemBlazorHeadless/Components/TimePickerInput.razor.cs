using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A time picker input is a component that allows users to select a specific time of day, often
/// used alongside a date picker in forms, scheduling tools, or booking systems. It provides a
/// structured way to enter time values, reducing input mistakes and improving the user experience
/// compared to free-text entry.
/// </summary>
/// <example>
/// <code>
/// &lt;TimePickerInput label="Appointment time" @bind-Value /&gt;
/// </code>
/// </example>
public partial class TimePickerInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "time-picker-input" : $"time-picker-input {CssClass}";
}
