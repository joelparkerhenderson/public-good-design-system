using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An action link is a headless anchor component that visually emphasizes a navigation action,
/// typically appearing as a prominent link that leads the user to a new page or triggers a
/// significant navigation event. Inspired by the NHS England action link pattern, it renders a
/// semantic `&lt;a&gt;` element with optional ARIA label override for screen readers.
/// </summary>
/// <example>
/// <code>
/// &lt;ActionLink href="/next-step"&gt;Continue to next step&lt;/ActionLink&gt;
/// </code>
/// </example>
public partial class ActionLink : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Href { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "action-link" : $"action-link {CssClass}";
}
