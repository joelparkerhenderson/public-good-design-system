using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A carousel is a region component for cycling through a set of slides or content items, such as
/// image galleries, product showcases, or testimonial rotators. It provides the semantic container
/// with appropriate ARIA roledescription so assistive technologies announce it as a carousel.
/// </summary>
/// <example>
/// <code>
/// &lt;Carousel label="Photo gallery"&gt;
///     &lt;div role="group" aria-label="Slide 1"&gt;...&lt;/div&gt;
/// &lt;/Carousel&gt;
/// </code>
/// </example>
public partial class Carousel : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "carousel" : $"carousel {CssClass}";
}
