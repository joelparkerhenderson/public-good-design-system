using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing one score in a Net Promoter Score picker. Renders a `&lt;button&gt;` with
/// `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// {#each Array.from({ length: 11 }, (_, i) =&gt; i) as score}
///   &lt;NetPromoterScorePickerButton
///     value=@score
///     label={String(score)}
///     selected={nps === score}
///     @onclick="HandleClick"
///   /&gt;
/// {/each}
/// </code>
/// </example>
public partial class NetPromoterScorePickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "net-promoter-score-picker-button" : $"net-promoter-score-picker-button {CssClass}";
}
