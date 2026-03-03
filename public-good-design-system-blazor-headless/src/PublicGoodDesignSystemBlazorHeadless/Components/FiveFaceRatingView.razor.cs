using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only five-face rating display that shows a text label corresponding to a rating value
/// from 1 to 5. This is the display-only companion to FiveFaceRatingPicker, used for showing
/// previously submitted ratings in summaries, review lists, or dashboard displays.
/// </summary>
/// <example>
/// <code>
/// &lt;FiveFaceRatingView value=@4 label="Good rating" /&gt;
/// </code>
/// </example>
public partial class FiveFaceRatingView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string[] Labels { get; set; } = ["Very bad", "Bad", "Okay", "Good", "Very good"];
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-face-rating-view" : $"five-face-rating-view {CssClass}";
}
