using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A date input provides a headless native HTML date input element with accessible labelling via
/// `aria-label`. It is a minimal wrapper for `&lt;input type="date"&gt;` that leverages the
/// browser's built-in date picker for date selection.
/// </summary>
/// <example>
/// <code>
/// &lt;DateInput label="Birth date" @bind-Value /&gt;
/// </code>
/// </example>
public partial class DateInput : ComponentBase
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

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "date-input" : $"date-input {CssClass}";
}
