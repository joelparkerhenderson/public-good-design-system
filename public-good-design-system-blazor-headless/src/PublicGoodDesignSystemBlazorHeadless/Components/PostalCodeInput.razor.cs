using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A postal code input provides a text field specifically designed for entering postal or ZIP
/// codes. It includes `autocomplete="postal-code"` to enable browsers to auto-fill the value from
/// stored address data, streamlining address form completion.
/// </summary>
/// <example>
/// <code>
/// &lt;PostalCodeInput label="Postal code" @bind-Value /&gt;
/// </code>
/// </example>
public partial class PostalCodeInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "postal-code-input" : $"postal-code-input {CssClass}";
}
