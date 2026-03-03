using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A warning callout is a component used to draw attention to important alerts or potential issues
/// that require user attention or caution. It highlights warnings, errors, or critical information
/// that could affect the user's experience or actions, and may include additional text or links to
/// help users understand the issue or take corrective actions.
/// </summary>
/// <example>
/// <code>
/// &lt;WarningCallout label="Warning"&gt;
///     &lt;p&gt;Your session is about to expire.&lt;/p&gt;
/// &lt;/WarningCallout&gt;
/// </code>
/// </example>
public partial class WarningCallout : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "warning-callout" : $"warning-callout {CssClass}";
}
