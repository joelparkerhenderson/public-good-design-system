using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A back link is a navigational component that allows users to return to a previous page or step
/// within an application. It renders as a semantic anchor (`&lt;a&gt;`) element with optional
/// `aria-label` for enhanced screen reader context.
/// </summary>
/// <example>
/// <code>
/// &lt;BackLink href="/previous-page"&gt;Back to previous page&lt;/BackLink&gt;
/// &lt;BackLink href="/dashboard" label="Return to dashboard"&gt;Back&lt;/BackLink&gt;
/// </code>
/// </example>
public partial class BackLink : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Href { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "back-link" : $"back-link {CssClass}";
}
