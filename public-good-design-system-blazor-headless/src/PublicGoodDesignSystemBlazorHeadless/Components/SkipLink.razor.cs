using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// SkipLink is a headless navigation link that allows keyboard users to bypass repetitive content
/// (such as navigation menus and headers) and jump directly to the main content area. It is one of
/// the most important accessibility features for keyboard-only users and screen reader users.
/// </summary>
/// <example>
/// <code>
/// &lt;SkipLink /&gt;
/// </code>
/// </example>
public partial class SkipLink : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Href { get; set; } = "#content";
    [Parameter] public string? Label { get; set; } = "Skip to content";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "skip-link" : $"skip-link {CssClass}";
}
