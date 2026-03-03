using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A week input is a UI/UX component that provides a field for selecting a specific week of the
/// year using the native HTML `&lt;input type="week"&gt;` element. It renders a week picker control
/// that allows users to select a year and week number, with values in YYYY-Www format (e.g.,
/// "2024-W01"). The component includes aria-label for accessibility and supports bindable value for
/// two-way data binding, along with standard form attributes like required and disabled.
/// </summary>
/// <example>
/// <code>
/// &lt;WeekInput label="Select week" @bind-Value /&gt;
/// </code>
/// </example>
public partial class WeekInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "week-input" : $"week-input {CssClass}";
}
