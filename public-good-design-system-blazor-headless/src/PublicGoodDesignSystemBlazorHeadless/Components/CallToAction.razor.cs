using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A call to action (CTA) is a component designed to prompt users to take a specific action, such
/// as navigating to a page or triggering an operation. CTAs are typically the most prominent
/// interactive element on a page, driving user engagement toward key goals like "Sign Up", "Learn
/// More", or "Buy Now".
/// </summary>
/// <example>
/// <code>
/// &lt;CallToAction href="/signup"&gt;Sign Up Now&lt;/CallToAction&gt;
/// &lt;CallToAction @onclick="handleAction"&gt;Get Started&lt;/CallToAction&gt;
/// </code>
/// </example>
public partial class CallToAction : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Href { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "call-to-action-link" : $"call-to-action-link {CssClass}";
}
