using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A flair is a small inline element used to add visual emphasis, categorization, or status
/// labeling to elements within an interface. Commonly used as tags, badges, or labels in forums,
/// social platforms, or dashboards, flair can indicate user roles, content types, statuses, or
/// categories (e.g., "Moderator", "Urgent", "New").
/// </summary>
/// <example>
/// <code>
/// &lt;Flair&gt;New&lt;/Flair&gt;
/// </code>
/// </example>
public partial class Flair : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "flair" : $"flair {CssClass}";
}
