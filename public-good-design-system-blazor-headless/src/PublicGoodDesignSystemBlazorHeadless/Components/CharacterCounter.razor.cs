using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A character counter displays the number of characters a user has typed into an input field,
/// providing real-time feedback to help users stay within constraints. It is commonly used
/// alongside text inputs with character limits such as tweets, SMS messages, form fields, or bios.
/// The counter shows "count / max" when a maximum is provided, or just the count otherwise.
/// </summary>
/// <example>
/// <code>
/// &lt;CharacterCounter count={text.length} max=@280 label="Characters" /&gt;
/// </code>
/// </example>
public partial class CharacterCounter : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Count { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private int Remaining => Max - Count;
    private bool OverLimit => Count > Max;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "character-counter" : $"character-counter {CssClass}";
}
