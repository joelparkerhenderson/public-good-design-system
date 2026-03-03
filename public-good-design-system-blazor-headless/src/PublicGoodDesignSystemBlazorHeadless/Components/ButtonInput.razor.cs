using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button input is a form component that wraps the native HTML `&lt;input type="button"&gt;`
/// element. Unlike the Button component which uses `&lt;button&gt;` and can contain rich content
/// (icons, formatted text) via children snippets, the button input displays its label as the
/// `value` attribute and renders only plain text.
/// </summary>
/// <example>
/// <code>
/// &lt;ButtonInput value="Click me" @onclick="handleClick" /&gt;
/// </code>
/// </example>
public partial class ButtonInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? Name { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "button-input" : $"button-input {CssClass}";
}
