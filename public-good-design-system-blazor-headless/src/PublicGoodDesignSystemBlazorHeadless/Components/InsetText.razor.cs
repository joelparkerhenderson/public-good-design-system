using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An inset text component is used to distinguish a block of content from the surrounding text,
/// drawing attention to important information that a user needs to know. It is commonly used in
/// government and institutional design systems to highlight supplementary information, processing
/// times, eligibility criteria, or important notices without using an alert or warning pattern.
/// </summary>
/// <example>
/// <code>
/// &lt;InsetText&gt;It can take up to 8 weeks to process.&lt;/InsetText&gt;
/// </code>
/// </example>
public partial class InsetText : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "inset-text" : $"inset-text {CssClass}";
}
