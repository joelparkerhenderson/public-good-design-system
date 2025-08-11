using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A hamburger menu is a headless toggle button that reveals or hides a navigation panel. It is
/// commonly used on mobile layouts and compact interfaces to conserve screen space by hiding the
/// primary navigation behind a toggle control.
/// </summary>
/// <example>
/// <code>
/// &lt;HamburgerMenu label="Main menu" @bind-Open&gt;
///   &lt;nav&gt;
///     &lt;ul&gt;
///       &lt;li&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/li&gt;
///       &lt;li&gt;&lt;a href="/about"&gt;About&lt;/a&gt;&lt;/li&gt;
///     &lt;/ul&gt;
///   &lt;/nav&gt;
/// &lt;/HamburgerMenu&gt;
/// </code>
/// </example>
public partial class HamburgerMenu : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; } = "Menu";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "hamburger-menu" : $"hamburger-menu {CssClass}";
}
