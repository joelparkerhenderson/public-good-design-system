using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A five-face rating picker allows users to select a satisfaction level from 1 to 5 using labeled
/// radio buttons representing faces from "Very bad" to "Very good". This pattern is commonly used
/// in satisfaction surveys, feedback forms, and experience ratings where face-based labels are more
/// intuitive than numeric scales. The component uses radio buttons grouped in a fieldset for proper
/// accessibility and keyboard navigation.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Basic face rating with two-way binding --&gt;
/// &lt;FiveFaceRatingPicker label="How was your experience?" @bind-Value /&gt;
/// 
/// &lt;!-- Custom face labels for localization or different scales --&gt;
/// &lt;FiveFaceRatingPicker label="Rate service" @bind-Value labels={["Terrible", "Poor", "Fair", "Great", "Excellent"]} /&gt;
/// 
/// &lt;!-- Disabled face rating --&gt;
/// &lt;FiveFaceRatingPicker label="Previous rating" value=@4 disabled /&gt;
/// 
/// &lt;!-- Custom name for form submission --&gt;
/// &lt;FiveFaceRatingPicker label="Satisfaction" @bind-Value name="satisfaction" /&gt;
/// </code>
/// </example>
public partial class FiveFaceRatingPicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int Value { get; set; }
    [Parameter] public EventCallback<int> ValueChanged { get; set; }
    [Parameter] public string? Name { get; set; } = "face-rating";
    [Parameter] public string[] Labels { get; set; } = ["Very bad", "Bad", "Okay", "Good", "Very good"];
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "five-face-rating-picker" : $"five-face-rating-picker {CssClass}";
}
