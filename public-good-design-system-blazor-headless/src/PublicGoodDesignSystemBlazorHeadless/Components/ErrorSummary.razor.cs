using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An error summary displays a consolidated list of form validation errors at the top of a form. It
/// alerts users to problems that need correction and provides links to the specific fields with
/// errors, following the pattern used by GOV.UK and NHS England design systems.
/// </summary>
/// <example>
/// <code>
/// &lt;ErrorSummary title="There is a problem"&gt;
///     &lt;ul&gt;
///         &lt;li&gt;&lt;a href="#name"&gt;Enter your name&lt;/a&gt;&lt;/li&gt;
///         &lt;li&gt;&lt;a href="#email"&gt;Enter a valid email address&lt;/a&gt;&lt;/li&gt;
///     &lt;/ul&gt;
/// &lt;/ErrorSummary&gt;
/// </code>
/// </example>
public partial class ErrorSummary : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Title { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private string TitleId => "error-summary-${Math.random().toString(36).slice(2, 9)}";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "error-summary" : $"error-summary {CssClass}";
}
