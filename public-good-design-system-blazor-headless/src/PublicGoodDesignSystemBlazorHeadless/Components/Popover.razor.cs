using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A popover is a UI component that displays contextual information or actions in an overlay that
/// appears near the element that triggered it. The Popover component provides a headless
/// conditional dialog container that renders its content only when the `open` state is true, with
/// proper dialog semantics for accessibility.
/// </summary>
/// <example>
/// <code>
/// &lt;button @onclick="HandleClick"&gt;Toggle info&lt;/button&gt;
/// &lt;Popover label="Additional information" @bind-Open="showPopover"&gt;
///   &lt;p&gt;Here is some contextual information.&lt;/p&gt;
///   &lt;button @onclick="HandleClick"&gt;Close&lt;/button&gt;
/// &lt;/Popover&gt;
/// </code>
/// </example>
public partial class Popover : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "popover" : $"popover {CssClass}";
}
