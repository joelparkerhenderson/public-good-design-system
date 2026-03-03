using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An alert is a UI/UX component designed to capture the user's attention and convey important
/// information, such as warnings, errors, confirmations, or status updates. Alerts interrupt the
/// user's workflow to ensure visibility and are commonly used for critical feedback or decision
/// points -- such as confirming deletion or notifying of failed actions. They should be clear,
/// concise, and appropriately styled (e.g., color-coded for severity by the consumer) to avoid
/// confusion or unnecessary disruption.
/// </summary>
/// <example>
/// <code>
/// &lt;Alert&gt;Something happened.&lt;/Alert&gt;
/// </code>
/// </example>
public partial class Alert : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Type { get; set; } = "info";
    [Parameter] public string? Heading { get; set; }
    [Parameter] public string? Role { get; set; } = "alert";
    [Parameter] public string? Live { get; set; }
    [Parameter] public string? AriaLive { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "alert" : $"alert {CssClass}";
}
