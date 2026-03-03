using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An error message component informs users when something has gone wrong, such as incorrect input,
/// failed actions, or system issues. It uses `role="alert"` to ensure screen readers announce the
/// error immediately when it appears, without requiring user focus.
/// </summary>
/// <example>
/// <code>
/// &lt;ErrorMessage&gt;Password is required&lt;/ErrorMessage&gt;
/// </code>
/// </example>
public partial class ErrorMessage : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "error-message" : $"error-message {CssClass}";
}
