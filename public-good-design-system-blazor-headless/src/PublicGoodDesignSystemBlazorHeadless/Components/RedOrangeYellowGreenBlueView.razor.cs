using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A ROYGB (Red/Orange/Yellow/Green/Blue) status view is a component that displays a five-level
/// color-coded status value as read-only text. It is used to present previously captured ROYGB
/// status data in dashboards, reports, or detail views. Red indicates a critical problem, orange
/// signals a hazard, yellow means caution, green indicates normal status, and blue represents a
/// paused or informational state.
/// </summary>
/// <example>
/// <code>
/// &lt;RedOrangeYellowGreenBlueView label="Risk level" value="yellow" /&gt;
/// </code>
/// </example>
public partial class RedOrangeYellowGreenBlueView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-orange-yellow-green-blue-view" : $"red-orange-yellow-green-blue-view {CssClass}";
}
