using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A progress circle indicates completion status using a `&lt;div&gt;` with ARIA Progress
/// semantics. Unlike a linear progress bar, the progress circle is intended to convey progress in a
/// radial layout, commonly used for loading indicators, completion percentages, and dashboard
/// widgets. The component is headless, so consumers provide their own CSS to create the circular
/// visual representation using the ARIA value attributes.
/// </summary>
/// <example>
/// <code>
/// &lt;ProgressCircle label="Upload" value=@75&gt;
///   &lt;span&gt;75%&lt;/span&gt;
/// &lt;/ProgressCircle&gt;
/// </code>
/// </example>
public partial class ProgressCircle : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int Value { get; set; }
    [Parameter] public int Min { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "progress-circle" : $"progress-circle {CssClass}";
}
