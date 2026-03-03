using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing one star in a five-star rating picker. Renders a `&lt;button&gt;` with
/// `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;FiveStarRatingPickerButton value=@1 label="1 star" selected={rating === 1} @onclick="HandleClick" /&gt;
/// &lt;FiveStarRatingPickerButton value=@2 label="2 stars" selected={rating === 2} @onclick="HandleClick" /&gt;
/// &lt;FiveStarRatingPickerButton value=@3 label="3 stars" selected={rating === 3} @onclick="HandleClick" /&gt;
/// &lt;FiveStarRatingPickerButton value=@4 label="4 stars" selected={rating === 4} @onclick="HandleClick" /&gt;
/// &lt;FiveStarRatingPickerButton value=@5 label="5 stars" selected={rating === 5} @onclick="HandleClick" /&gt;
/// </code>
/// </example>
public partial class FiveStarRatingPickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-star-rating-picker-button" : $"five-star-rating-picker-button {CssClass}";
}
