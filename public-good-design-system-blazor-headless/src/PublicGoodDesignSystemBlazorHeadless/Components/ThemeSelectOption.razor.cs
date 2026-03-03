using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A theme select option is a single `&lt;option&gt;` element for use inside a ThemeSelect
/// dropdown. It represents one available theme choice such as light, dark, high-contrast, or system
/// default. The component wraps the native HTML `&lt;option&gt;` element with Svelte 5 runes and
/// accepts a value prop for the theme identifier and children for the visible label text.
/// </summary>
/// <example>
/// <code>
/// &lt;ThemeSelect label="Theme" @bind-Value="theme"&gt;
///   &lt;ThemeSelectOption value="light"&gt;Light&lt;/ThemeSelectOption&gt;
///   &lt;ThemeSelectOption value="dark"&gt;Dark&lt;/ThemeSelectOption&gt;
///   &lt;ThemeSelectOption value="high-contrast"&gt;High Contrast&lt;/ThemeSelectOption&gt;
///   &lt;ThemeSelectOption value="system"&gt;System Default&lt;/ThemeSelectOption&gt;
/// &lt;/ThemeSelect&gt;
/// </code>
/// </example>
public partial class ThemeSelectOption : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "theme-select-option" : $"theme-select-option {CssClass}";
}
