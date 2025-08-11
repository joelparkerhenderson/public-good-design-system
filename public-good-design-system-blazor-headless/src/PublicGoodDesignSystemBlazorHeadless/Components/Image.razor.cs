using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An image component displays visual content such as photographs, illustrations, or diagrams
/// within an interface. The Image component provides a headless wrapper that ensures proper
/// accessibility through required alt text and optional caption support via the HTML
/// `&lt;figure&gt;` and `&lt;figcaption&gt;` elements.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Basic image with alt text --&gt;
/// &lt;Image src="/photo.jpg" alt="A sunset over the ocean" /&gt;
/// 
/// &lt;!-- Image with caption wrapped in figure/figcaption --&gt;
/// &lt;Image src="/photo.jpg" alt="A sunset over the ocean" caption="Photo by Jane Doe" /&gt;
/// 
/// &lt;!-- Lazy-loaded image --&gt;
/// &lt;Image src="/large-photo.jpg" alt="Landscape" loading="lazy" /&gt;
/// </code>
/// </example>
public partial class Image : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Src { get; set; } = "";
    [Parameter] public string Alt { get; set; } = "";
    [Parameter] public string? Caption { get; set; }
    [Parameter] public string? Loading { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "image" : $"image {CssClass}";
}
