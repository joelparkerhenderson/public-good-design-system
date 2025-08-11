using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// ToggleGroup is a headless container for a collection of related toggle buttons. It uses the ARIA
/// `group` role with an accessible label to semantically associate toggle buttons, making their
/// relationship understandable to assistive technologies.
/// </summary>
/// <example>
/// <code>
/// &lt;ToggleGroup label="Text formatting"&gt;
///   &lt;button aria-pressed="true"&gt;Bold&lt;/button&gt;
///   &lt;button aria-pressed="false"&gt;Italic&lt;/button&gt;
/// &lt;/ToggleGroup&gt;
/// </code>
/// </example>
public partial class ToggleGroup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "toggle-group" : $"toggle-group {CssClass}";
}
