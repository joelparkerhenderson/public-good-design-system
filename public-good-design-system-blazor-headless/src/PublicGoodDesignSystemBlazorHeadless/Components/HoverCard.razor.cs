using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// HoverCard is a headless component that displays supplementary content when triggered, typically
/// by a hover or focus interaction on a trigger element. It conditionally renders a container with
/// `role="tooltip"` and an accessible label when the `open` prop is true.
/// </summary>
/// <example>
/// <code>
/// &lt;button
///   onmouseenter={() =&gt; open = true}
///   onmouseleave={() =&gt; open = false}
///   onfocus={() =&gt; open = true}
///   onblur={() =&gt; open = false}
/// &gt;
///   Hover me
/// &lt;/button&gt;
/// &lt;HoverCard label="User info" @bind-Open&gt;
///   &lt;p&gt;Profile details here&lt;/p&gt;
/// &lt;/HoverCard&gt;
/// </code>
/// </example>
public partial class HoverCard : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "hover-card" : $"hover-card {CssClass}";
}
