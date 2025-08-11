using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// ThemePicker is a headless theme selection component that renders a `&lt;fieldset&gt;` with the
/// `radiogroup` role. It provides an accessible container for radio button options that let users
/// choose between themes such as light, dark, or system preference.
/// </summary>
/// <example>
/// <code>
/// &lt;ThemePicker label="Theme"&gt;
///   &lt;label&gt;&lt;input type="radio" name="theme" value="light" /&gt; Light&lt;/label&gt;
///   &lt;label&gt;&lt;input type="radio" name="theme" value="dark" /&gt; Dark&lt;/label&gt;
/// &lt;/ThemePicker&gt;
/// </code>
/// </example>
public partial class ThemePicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "theme-picker" : $"theme-picker {CssClass}";
}
