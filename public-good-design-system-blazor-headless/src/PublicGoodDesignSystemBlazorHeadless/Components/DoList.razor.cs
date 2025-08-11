using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A do list presents recommended actions or best practices as a list of items. It is used in
/// design system documentation, guidelines, and instructional content to clearly communicate what
/// users or developers should do. The list is paired with the DontList component to create do/don't
/// guidance patterns.
/// </summary>
/// <example>
/// <code>
/// &lt;DoList&gt;
///     &lt;li&gt;Write clear labels&lt;/li&gt;
///     &lt;li&gt;Use semantic HTML&lt;/li&gt;
/// &lt;/DoList&gt;
/// </code>
/// </example>
public partial class DoList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; } = "Do";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "do-list" : $"do-list {CssClass}";
}
