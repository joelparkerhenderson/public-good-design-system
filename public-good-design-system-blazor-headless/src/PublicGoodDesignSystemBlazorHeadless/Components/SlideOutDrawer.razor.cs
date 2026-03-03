using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A slide-out drawer is a UI/UX component that slides in from the side of the screen -- usually
/// from the left or right -- to reveal additional content or navigation options without leaving the
/// current page. Often triggered by a button or swipe gesture, it is commonly used for menus,
/// filters, settings, or secondary content in mobile and web applications. This component allows
/// for efficient use of screen space by keeping less frequently used options hidden until needed,
/// enhancing focus and minimizing clutter in the main interface while maintaining easy access to
/// extended functionality.
/// </summary>
/// <example>
/// <code>
/// &lt;button @onclick="HandleClick"&gt;Open menu&lt;/button&gt;
/// 
/// &lt;SlideOutDrawer label="Navigation menu" @bind-Open="isOpen"&gt;
///   &lt;nav&gt;
///     &lt;ul&gt;
///       &lt;li&gt;&lt;a href="/"&gt;Home&lt;/a&gt;&lt;/li&gt;
///       &lt;li&gt;&lt;a href="/about"&gt;About&lt;/a&gt;&lt;/li&gt;
///       &lt;li&gt;&lt;a href="/contact"&gt;Contact&lt;/a&gt;&lt;/li&gt;
///     &lt;/ul&gt;
///   &lt;/nav&gt;
///   &lt;button @onclick="HandleClick"&gt;Close&lt;/button&gt;
/// &lt;/SlideOutDrawer&gt;
/// </code>
/// </example>
public partial class SlideOutDrawer : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private Task HandleKeyDown(KeyboardEventArgs e) => Task.CompletedTask;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "slide-out-drawer" : $"slide-out-drawer {CssClass}";
}
