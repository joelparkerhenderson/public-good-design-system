using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// SegmentGroup is a headless container for segmented controls that uses the ARIA `radiogroup`
/// role. It groups a set of mutually exclusive options, such as view mode toggles (grid/list),
/// filter selections, or display density controls.
/// </summary>
/// <example>
/// <code>
/// &lt;SegmentGroup label="View"&gt;
///   &lt;button role="radio" aria-checked="true"&gt;Grid&lt;/button&gt;
///   &lt;button role="radio" aria-checked="false"&gt;List&lt;/button&gt;
/// &lt;/SegmentGroup&gt;
/// </code>
/// </example>
public partial class SegmentGroup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "segment-group" : $"segment-group {CssClass}";
}
