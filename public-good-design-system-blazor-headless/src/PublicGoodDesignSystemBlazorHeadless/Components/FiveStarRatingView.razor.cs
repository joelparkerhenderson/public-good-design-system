using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A read-only five-star rating display that renders filled and empty star characters to visually
/// represent a rating value from 0 to 5. This is the display-only companion to
/// FiveStarRatingPicker, used for showing ratings in product listings, review summaries, and user
/// profiles. Screen readers receive the full rating description via `aria-label` rather than
/// reading individual star characters.
/// </summary>
/// <example>
/// <code>
/// &lt;FiveStarRatingView value=@4 label="4 out of 5 stars" /&gt;
/// </code>
/// </example>
public partial class FiveStarRatingView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-star-rating-view" : $"five-star-rating-view {CssClass}";
}
