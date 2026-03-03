using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single expandable section within an AccordionNavList, using the native HTML `&lt;details&gt;`
/// element for built-in disclosure behavior. The consumer provides a `&lt;summary&gt;` element and
/// content as children.
/// </summary>
/// <example>
/// <code>
/// &lt;AccordionNavListItem&gt;
///   &lt;summary&gt;Question&lt;/summary&gt;
///   &lt;p&gt;Answer&lt;/p&gt;
/// &lt;/AccordionNavListItem&gt;
/// </code>
/// </example>
public partial class AccordionNavListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "accordion-nav-list-item" : $"accordion-nav-list-item {CssClass}";
}
