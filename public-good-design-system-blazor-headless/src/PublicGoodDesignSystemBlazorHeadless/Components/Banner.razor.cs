using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A banner is a prominent component used to display important messages, updates, or calls to
/// action at the top or bottom of an interface. Often spanning the full width of the screen,
/// banners are designed to catch the user's attention without fully interrupting their experience.
/// They are commonly used for announcements, cookie consent, warnings, promotions, or system
/// alerts.
/// </summary>
/// <example>
/// <code>
/// &lt;Banner&gt;Important announcement here.&lt;/Banner&gt;
/// </code>
/// </example>
public partial class Banner : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Type { get; set; } = "info";
    [Parameter] public bool Dismissible { get; set; }
    [Parameter] public string? CloseLabel { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private bool Visible { get; set; } = true;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "banner" : $"banner {CssClass}";
}
