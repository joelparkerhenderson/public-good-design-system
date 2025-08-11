using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An emoji component wraps an emoji character with proper accessibility semantics so that screen
/// readers announce a meaningful description instead of attempting to read the raw Unicode
/// character. This ensures emoji usage in interfaces is accessible to all users.
/// </summary>
/// <example>
/// <code>
/// &lt;Emoji emoji="👍" label="Thumbs up" /&gt;
/// </code>
/// </example>
public partial class Emoji : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string EmojiChar { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "emoji" : $"emoji {CssClass}";
}
