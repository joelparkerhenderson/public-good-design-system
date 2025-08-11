using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A telephone input component that provides a telephone number input field using the native HTML
/// `&lt;input type="tel"&gt;` element. It includes accessible labeling via `aria-label` and browser
/// autofill support via `autocomplete="tel"`, making it suitable for contact forms, registration
/// flows, and profile editors.
/// </summary>
/// <example>
/// <code>
/// &lt;TelInput label="Phone number" @bind-Value /&gt;
/// </code>
/// </example>
public partial class TelInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tel-input" : $"tel-input {CssClass}";
}
