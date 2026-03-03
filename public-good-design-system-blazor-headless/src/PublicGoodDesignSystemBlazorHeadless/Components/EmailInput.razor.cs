using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An email input wraps a native `&lt;input type="email"&gt;` with accessible labeling. Provides a
/// streamlined API for basic email collection with required and disabled state support.
/// </summary>
/// <example>
/// <code>
/// &lt;EmailInput label="Your email" @bind-Value /&gt;
/// </code>
/// </example>
public partial class EmailInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "email-input" : $"email-input {CssClass}";
}
