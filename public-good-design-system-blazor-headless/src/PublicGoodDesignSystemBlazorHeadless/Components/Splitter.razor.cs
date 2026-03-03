using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// Splitter is a headless separator element used between resizable panels. It uses the ARIA
/// `separator` role to indicate a draggable divider, with keyboard focus support and value tracking
/// for reporting the current split position to assistive technologies.
/// </summary>
/// <example>
/// <code>
/// &lt;Splitter label="Resize panels" orientation="vertical" /&gt;
/// </code>
/// </example>
public partial class Splitter : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Orientation { get; set; } = "vertical";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "splitter" : $"splitter {CssClass}";
}
