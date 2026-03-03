using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// ScrollArea is a headless scrollable container that provides keyboard accessibility for
/// overflowing content. It renders a focusable region so keyboard users can scroll through content
/// using standard scrolling keys without needing a mouse.
/// </summary>
/// <example>
/// <code>
/// &lt;ScrollArea label="Scrollable content"&gt;
///   &lt;p&gt;Long content...&lt;/p&gt;
/// &lt;/ScrollArea&gt;
/// </code>
/// </example>
public partial class ScrollArea : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "scroll-area" : $"scroll-area {CssClass}";
}
