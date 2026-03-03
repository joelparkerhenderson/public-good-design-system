using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// TagGroup is a headless container for a collection of related tags. It uses the ARIA `group` role
/// with an accessible label to semantically associate tag elements, making the collection
/// understandable to screen readers and other assistive technologies.
/// </summary>
/// <example>
/// <code>
/// &lt;TagGroup label="Technologies"&gt;
///   &lt;Tag&gt;Svelte&lt;/Tag&gt;
///   &lt;Tag&gt;TypeScript&lt;/Tag&gt;
/// &lt;/TagGroup&gt;
/// </code>
/// </example>
public partial class TagGroup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tag-group" : $"tag-group {CssClass}";
}
