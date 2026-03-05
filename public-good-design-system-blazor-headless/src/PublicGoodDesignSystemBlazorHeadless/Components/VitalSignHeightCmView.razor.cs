using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only display of a vital sign height in centimeters. This component renders the
/// numeric value as text content within a span element, with ARIA attributes for accessibility.
/// Screen readers receive the full description via `aria-label` rather than reading the raw number.
/// </summary>
/// <example>
/// <code>
/// &lt;VitalSignHeightCmView Value=@175 Label="175 cm height" /&gt;
/// </code>
/// </example>
public partial class VitalSignHeightCmView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "vital-sign-height-cm-view" : $"vital-sign-height-cm-view {CssClass}";
}
