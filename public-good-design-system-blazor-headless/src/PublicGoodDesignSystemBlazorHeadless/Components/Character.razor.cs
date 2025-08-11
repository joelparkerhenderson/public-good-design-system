using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A character component displays a single character (glyph, symbol, emoji, or letter) with proper
/// accessibility semantics. When the character conveys meaning (like a checkmark for success or a
/// warning symbol), it uses `role="img"` with an `aria-label` so screen readers announce its
/// purpose. When the character is purely decorative, the `decorative` prop hides it from assistive
/// technologies.
/// </summary>
/// <example>
/// <code>
/// &lt;Character label="Check mark"&gt;✓&lt;/Character&gt;
/// &lt;Character label="Warning symbol"&gt;⚠&lt;/Character&gt;
/// &lt;Character decorative&gt;★&lt;/Character&gt;
/// </code>
/// </example>
public partial class Character : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Decorative { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "character" : $"character {CssClass}";
}
