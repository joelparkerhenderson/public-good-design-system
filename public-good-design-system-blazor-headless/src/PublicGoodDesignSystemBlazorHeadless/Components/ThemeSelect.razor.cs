using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A theme select is a headless component that allows users to switch between different visual
/// themes or color schemes using a native `&lt;select&gt;` dropdown. It is commonly used to offer
/// light, dark, high-contrast, or other visual modes, enhancing personalization and accessibility
/// by letting users adapt the interface to their preferences or environment.
/// </summary>
/// <example>
/// <code>
/// &lt;ThemeSelect label="Theme" @bind-Value&gt;
///   &lt;ThemeSelectOption value="light"&gt;Light&lt;/ThemeSelectOption&gt;
///   &lt;ThemeSelectOption value="dark"&gt;Dark&lt;/ThemeSelectOption&gt;
/// &lt;/ThemeSelect&gt;
/// </code>
/// </example>
public partial class ThemeSelect : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "theme-select" : $"theme-select {CssClass}";
}
