using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A text input provides a single-line text field for entering short text values such as names,
/// titles, or other brief textual data. It wraps the native HTML `&lt;input type="text"&gt;`
/// element with accessible labelling and two-way data binding.
/// </summary>
/// <example>
/// <code>
/// &lt;TextInput label="Full name" @bind-Value /&gt;
/// </code>
/// </example>
public partial class TextInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "text-input" : $"text-input {CssClass}";
}
