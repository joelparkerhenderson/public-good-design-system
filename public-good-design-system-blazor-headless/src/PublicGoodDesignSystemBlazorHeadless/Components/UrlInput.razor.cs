using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A URL input is a UI/UX component that provides a text field specifically for entering web
/// addresses. It uses the native HTML `&lt;input type="url"&gt;` element, which provides built-in
/// URL validation and may trigger URL-specific keyboard layouts on mobile devices. The component
/// includes aria-label for accessibility and supports bindable value for two-way data binding,
/// along with standard form attributes like required and disabled.
/// </summary>
/// <example>
/// <code>
/// &lt;UrlInput label="Website URL" @bind-Value /&gt;
/// </code>
/// </example>
public partial class UrlInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "url-input" : $"url-input {CssClass}";
}
