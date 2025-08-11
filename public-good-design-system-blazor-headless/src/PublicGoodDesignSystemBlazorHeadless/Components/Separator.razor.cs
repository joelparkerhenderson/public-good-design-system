using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A separator is a UI/UX component that provides a visual and semantic divider between sections of
/// content. It uses the native HTML `&lt;hr&gt;` element with an explicit `role="separator"` for
/// proper accessibility semantics. An optional label prop can be used to provide additional context
/// about the separation for screen readers.
/// </summary>
/// <example>
/// <code>
/// &lt;Separator /&gt;
/// </code>
/// </example>
public partial class Separator : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "separator" : $"separator {CssClass}";
}
