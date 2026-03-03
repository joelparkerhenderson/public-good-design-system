using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A checkbox input is a minimal headless wrapper around the native HTML `&lt;input
/// type="checkbox"&gt;` element. Unlike a Checkbox component which includes a wrapping
/// `&lt;label&gt;`, CheckboxInput uses `aria-label` for accessibility, giving consumers full
/// control over label placement and visual presentation.
/// </summary>
/// <example>
/// <code>
/// &lt;CheckboxInput label="Accept terms" @bind-Checked /&gt;
/// </code>
/// </example>
public partial class CheckboxInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Checked { get; set; }
    [Parameter] public EventCallback<bool> CheckedChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public string? Name { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "checkbox-input" : $"checkbox-input {CssClass}";
}
