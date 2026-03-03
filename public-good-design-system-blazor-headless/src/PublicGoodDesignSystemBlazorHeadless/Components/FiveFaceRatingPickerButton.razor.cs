using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing one face in a five-face rating picker. Renders a `&lt;button&gt;` with
/// `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;FiveFaceRatingPickerButton value=@1 label="Very bad" selected={rating === 1} @onclick="HandleClick" /&gt;
/// &lt;FiveFaceRatingPickerButton value=@2 label="Bad" selected={rating === 2} @onclick="HandleClick" /&gt;
/// &lt;FiveFaceRatingPickerButton value=@3 label="Okay" selected={rating === 3} @onclick="HandleClick" /&gt;
/// &lt;FiveFaceRatingPickerButton value=@4 label="Good" selected={rating === 4} @onclick="HandleClick" /&gt;
/// &lt;FiveFaceRatingPickerButton value=@5 label="Very good" selected={rating === 5} @onclick="HandleClick" /&gt;
/// </code>
/// </example>
public partial class FiveFaceRatingPickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-face-rating-picker-button" : $"five-face-rating-picker-button {CssClass}";
}
