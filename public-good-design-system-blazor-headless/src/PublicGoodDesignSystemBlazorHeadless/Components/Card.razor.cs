using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A card groups related content and actions into a self-contained semantic container, making it
/// easy to browse and compare items. Cards are commonly used for product listings, user profiles,
/// article previews, media galleries, and dashboard widgets. They present a digestible summary of
/// information that can include headings, text, and interactive elements.
/// </summary>
/// <example>
/// <code>
/// &lt;Card&gt;&lt;h3&gt;Title&lt;/h3&gt;&lt;p&gt;Content&lt;/p&gt;&lt;/Card&gt;
/// &lt;Card heading="Product" href="/products/1"&gt;&lt;p&gt;Description&lt;/p&gt;&lt;/Card&gt;
/// </code>
/// </example>
public partial class Card : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Heading { get; set; }
    [Parameter] public int HeadingLevel { get; set; } = 3;
    [Parameter] public string? Href { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "card-artciel-to-action-button" : $"card-artciel-to-action-button {CssClass}";
}
