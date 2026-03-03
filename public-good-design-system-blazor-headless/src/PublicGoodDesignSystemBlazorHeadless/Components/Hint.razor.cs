using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A hint provides subtle, contextual guidance text associated with a form control. It is typically
/// displayed near an input field to clarify expected formats, explain functionality, or offer
/// examples. The component renders a `&lt;p&gt;` element with an optional `id` for linking to a
/// form control via `aria-describedby`.
/// </summary>
/// <example>
/// <code>
/// &lt;Hint id="email-hint"&gt;Enter your work email&lt;/Hint&gt;
/// &lt;input aria-describedby="email-hint" /&gt;
/// </code>
/// </example>
public partial class Hint : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "hint" : $"hint {CssClass}";
}
