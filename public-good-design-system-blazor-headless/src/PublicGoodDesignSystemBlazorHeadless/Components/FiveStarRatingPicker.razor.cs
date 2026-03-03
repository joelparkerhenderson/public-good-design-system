using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A five-star rating input allows users to select a rating from 1 to 5 stars using radio buttons.
/// This is one of the most common rating patterns on the web, used for product reviews, content
/// ratings, and feedback forms. Each radio button is labeled with "N star" or "N stars" for clear
/// screen reader communication. The component uses radio buttons grouped in a fieldset for proper
/// accessibility and keyboard navigation.
/// </summary>
/// <example>
/// <code>
/// &lt;FiveStarRatingPicker label="Rate this" @bind-Value /&gt;
/// </code>
/// </example>
public partial class FiveStarRatingPicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int Value { get; set; } = 0;
    [Parameter] public EventCallback<int> ValueChanged { get; set; }
    [Parameter] public string? Name { get; set; } = "rating";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-star-rating-picker" : $"five-star-rating-picker {CssClass}";
}
