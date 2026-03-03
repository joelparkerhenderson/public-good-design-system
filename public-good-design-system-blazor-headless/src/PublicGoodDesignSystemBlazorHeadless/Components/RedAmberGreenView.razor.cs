using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A RAG (Red/Amber/Green) status view is a component that displays a traffic-light status value as
/// read-only text. It is used to present previously captured RAG status data in dashboards,
/// reports, or detail views. Red indicates a critical problem, amber signals caution or minor
/// issues, and green means everything is on track.
/// </summary>
/// <example>
/// <code>
/// &lt;RedAmberGreenView label="Project status" value="green" /&gt;
/// </code>
/// </example>
public partial class RedAmberGreenView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-amber-green-view" : $"red-amber-green-view {CssClass}";
}
