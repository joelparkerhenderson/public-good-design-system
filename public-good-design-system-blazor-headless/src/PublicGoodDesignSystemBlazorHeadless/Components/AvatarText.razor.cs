using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An avatar circle text is the initials/text fallback within an Avatar. It renders a
/// `&lt;span&gt;` with `aria-hidden="true"` containing initials or short text that represents the
/// user when no image is available.
/// </summary>
/// <example>
/// <code>
/// &lt;Avatar alt="Jane Doe"&gt;
///   &lt;AvatarText&gt;JD&lt;/AvatarText&gt;
/// &lt;/Avatar&gt;
/// </code>
/// </example>
public partial class AvatarText : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "avatar-text" : $"avatar-text {CssClass}";
}
