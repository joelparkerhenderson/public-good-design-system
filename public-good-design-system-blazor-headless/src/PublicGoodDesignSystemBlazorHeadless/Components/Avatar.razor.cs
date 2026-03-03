using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An avatar circle is a container that displays a user's profile image or fallback initials within
/// a circular frame, commonly used to represent a user identity in apps, websites, and social
/// platforms. This visual element provides a quick, recognizable way for users to identify
/// themselves or others, often appearing in headers, comments, chat interfaces, and account menus.
/// </summary>
/// <example>
/// <code>
/// &lt;Avatar alt="Jane Doe"&gt;
///   &lt;AvatarImage src="/photo.jpg" alt="Jane Doe" /&gt;
/// &lt;/Avatar&gt;
/// </code>
/// </example>
public partial class Avatar : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Alt { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "avatar" : $"avatar {CssClass}";
}
