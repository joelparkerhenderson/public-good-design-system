using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A header is a headless component that renders a semantic `&lt;header&gt;` element, providing a
/// landmark region for introductory or navigational content. It is typically positioned at the top
/// of a page or section and contains elements like headings, navigation links, branding, search
/// controls, or call-to-action buttons.
/// </summary>
/// <example>
/// <code>
/// &lt;Header label="Site header"&gt;
///   &lt;h1&gt;My Site&lt;/h1&gt;
/// &lt;/Header&gt;
/// </code>
/// </example>
public partial class Header : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "header" : $"header {CssClass}";
}
