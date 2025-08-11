using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A don't list presents discouraged actions or practices to avoid as a list of items. It is used
/// in design system documentation, guidelines, and instructional content to clearly communicate
/// what users or developers should not do. The list is paired with the DoList component to create
/// do/don't guidance patterns.
/// </summary>
/// <example>
/// <code>
/// &lt;DontList&gt;
///     &lt;li&gt;Skip alt text&lt;/li&gt;
///     &lt;li&gt;Use only color for meaning&lt;/li&gt;
/// &lt;/DontList&gt;
/// </code>
/// </example>
public partial class DontList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; } = "Don't";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "dont-list" : $"dont-list {CssClass}";
}
