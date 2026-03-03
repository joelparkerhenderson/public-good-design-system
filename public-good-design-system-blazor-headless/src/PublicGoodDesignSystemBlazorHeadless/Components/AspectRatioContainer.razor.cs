using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An aspect ratio component is a layout utility that constrains its content to a specific
/// width-to-height ratio. It ensures that images, videos, maps, and other embedded content maintain
/// consistent proportions regardless of the container size. Common aspect ratios include 16:9
/// (widescreen video), 4:3 (traditional display), 1:1 (square, often for avatars or thumbnails),
/// and 21:9 (ultrawide).
/// </summary>
/// <example>
/// <code>
/// &lt;AspectRatioContainer ratio={16/9}&gt;
///   &lt;video src="video.mp4"&gt;&lt;/video&gt;
/// &lt;/AspectRatioContainer&gt;
/// 
/// &lt;AspectRatioContainer ratio=@1&gt;
///   &lt;img src="avatar.jpg" alt="User avatar" /&gt;
/// &lt;/AspectRatioContainer&gt;
/// </code>
/// </example>
public partial class AspectRatioContainer : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Ratio { get; set; } = 1;
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "aspect-ratio-container" : $"aspect-ratio-container {CssClass}";
}
