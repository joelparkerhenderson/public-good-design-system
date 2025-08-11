using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A navigation container for an accordion. Renders a `&lt;nav&gt;` element with an accessible
/// label, serving as the outermost wrapper for collapsible accordion content. Commonly used for
/// FAQs, settings panels, filter groups, and mobile navigation menus.
/// </summary>
/// <example>
/// <code>
/// &lt;AccordionNav label="Frequently Asked Questions"&gt;
///   &lt;AccordionNavList&gt;
///     &lt;AccordionNavListItem&gt;
///       &lt;summary&gt;What is this?&lt;/summary&gt;
///       &lt;p&gt;A design system.&lt;/p&gt;
///     &lt;/AccordionNavListItem&gt;
///   &lt;/AccordionNavList&gt;
/// &lt;/AccordionNav&gt;
/// </code>
/// </example>
public partial class AccordionNav : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "accordion-nav" : $"accordion-nav {CssClass}";
}
