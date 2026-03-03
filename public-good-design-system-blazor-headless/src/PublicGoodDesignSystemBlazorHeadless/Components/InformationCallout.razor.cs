using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// InformationCallout is a headless component that highlights important information in a
/// semantically distinct container. It renders an `&lt;aside&gt;` element with `role="note"` and an
/// accessible label, making the callout content identifiable to assistive technologies as
/// supplementary information.
/// </summary>
/// <example>
/// <code>
/// &lt;InformationCallout label="Note"&gt;
///   &lt;p&gt;This feature is in beta.&lt;/p&gt;
/// &lt;/InformationCallout&gt;
/// </code>
/// </example>
public partial class InformationCallout : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "information-callout" : $"information-callout {CssClass}";
}
