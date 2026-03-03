using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A disclosure widget that reveals or hides additional content on demand. Built on the native HTML
/// `&lt;details&gt;` and `&lt;summary&gt;` elements, this component provides progressive disclosure
/// -- showing only what is necessary upfront and letting users expand sections for more
/// information. Common use cases include FAQs, collapsible sections, advanced options, and
/// supplementary explanations.
/// </summary>
/// <example>
/// <code>
/// &lt;Details summary="More information"&gt;
///   &lt;p&gt;Additional details shown when expanded.&lt;/p&gt;
/// &lt;/Details&gt;
/// </code>
/// </example>
public partial class Details : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Summary { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "details" : $"details {CssClass}";
}
