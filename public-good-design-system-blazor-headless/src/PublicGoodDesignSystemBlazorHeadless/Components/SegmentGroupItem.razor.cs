using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// SegmentGroupItem is a single segment option within a SegmentGroup. It renders as a
/// `&lt;button&gt;` with `role="radio"` and `aria-checked`, following the WAI-ARIA radio group
/// pattern. Each item represents one mutually exclusive option in the segmented control.
/// </summary>
/// <example>
/// <code>
/// &lt;SegmentGroup label="View"&gt;
///   &lt;SegmentGroupItem checked={mode === 'grid'} value="grid" @onclick="HandleClick"&gt;
///     Grid
///   &lt;/SegmentGroupItem&gt;
///   &lt;SegmentGroupItem checked={mode === 'list'} value="list" @onclick="HandleClick"&gt;
///     List
///   &lt;/SegmentGroupItem&gt;
/// &lt;/SegmentGroup&gt;
/// </code>
/// </example>
public partial class SegmentGroupItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Checked { get; set; }
    [Parameter] public string? Value { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "segment-group-item" : $"segment-group-item {CssClass}";
}
