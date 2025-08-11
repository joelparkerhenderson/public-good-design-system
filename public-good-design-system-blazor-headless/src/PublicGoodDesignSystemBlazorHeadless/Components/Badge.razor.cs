using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A badge is a small inline component for displaying dynamic status information, counts, or short
/// labels in a compact, prominent format. Badges are commonly used to show unread message counts,
/// notification indicators, or activity statuses attached to icons, buttons, or list items.
/// </summary>
/// <example>
/// <code>
/// &lt;Badge&gt;New&lt;/Badge&gt;
/// &lt;Badge label="3 unread messages"&gt;3&lt;/Badge&gt;
/// &lt;Badge type="warning"&gt;Alert&lt;/Badge&gt;
/// </code>
/// </example>
public partial class Badge : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Type { get; set; } = "default";
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "badge" : $"badge {CssClass}";
}
