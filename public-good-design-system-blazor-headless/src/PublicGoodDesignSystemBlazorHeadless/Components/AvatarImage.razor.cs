using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An avatar circle image is the profile photo element within an Avatar. It renders a native
/// `&lt;img&gt;` element with `aria-hidden="true"` to prevent duplicate announcements (since the
/// parent Avatar already has `aria-label`).
/// </summary>
/// <example>
/// <code>
/// &lt;Avatar alt="Jane Doe"&gt;
///   &lt;AvatarImage src="/photos/jane.jpg" alt="Jane Doe" /&gt;
/// &lt;/Avatar&gt;
/// </code>
/// </example>
public partial class AvatarImage : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Src { get; set; } = "";
    [Parameter] public string Alt { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "avatar-image" : $"avatar-image {CssClass}";
}
