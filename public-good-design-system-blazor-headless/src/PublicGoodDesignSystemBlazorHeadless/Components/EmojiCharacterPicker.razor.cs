using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An emoji character picker is a component that presents a grid of emoji characters for users to
/// browse and select from. Commonly used in messaging applications, social media platforms, comment
/// systems, and rich text editors, the emoji character picker provides an organized interface for
/// inserting emoji into text, often organized by category such as smileys, animals, food, and
/// symbols.
/// </summary>
/// <example>
/// <code>
/// &lt;EmojiCharacterPicker label="Choose an emoji"&gt;
///     &lt;div role="row"&gt;
///         &lt;button role="gridcell"&gt;😀&lt;/button&gt;
///         &lt;button role="gridcell"&gt;😂&lt;/button&gt;
///         &lt;button role="gridcell"&gt;😍&lt;/button&gt;
///     &lt;/div&gt;
/// &lt;/EmojiCharacterPicker&gt;
/// </code>
/// </example>
public partial class EmojiCharacterPicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "emoji-character-picker" : $"emoji-character-picker {CssClass}";
}
