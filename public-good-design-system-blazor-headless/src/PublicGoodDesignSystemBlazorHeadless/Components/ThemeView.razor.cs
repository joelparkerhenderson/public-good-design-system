using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// ThemeView is a headless component that displays the current theme name as inline text. It
/// renders the theme value in a `&lt;span&gt;` element with an accessible label, making the current
/// theme selection readable by screen readers.
/// </summary>
/// <example>
/// <code>
/// &lt;ThemeView label="Current theme" value="dark" /&gt;
/// </code>
/// </example>
public partial class ThemeView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string Value { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "theme-view" : $"theme-view {CssClass}";
}
