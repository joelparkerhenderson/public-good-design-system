using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A beach ball is a loading/waiting indicator component, inspired by the colorful spinning cursor
/// on macOS that appears when the system is busy. It provides a visual cue that a process is in
/// progress and communicates to users that the system is working on a task.
/// </summary>
/// <example>
/// <code>
/// &lt;BeachBall label="Loading content" /&gt;
/// </code>
/// </example>
public partial class BeachBall : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Active { get; set; } = true;
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "beach-ball" : $"beach-ball {CssClass}";
}
