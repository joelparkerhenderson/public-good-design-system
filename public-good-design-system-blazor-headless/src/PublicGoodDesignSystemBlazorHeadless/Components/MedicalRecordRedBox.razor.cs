using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A medical patient banner danger box is a container for critical patient danger information. It
/// uses `&lt;aside role="alert"&gt;` with an aria-label to immediately announce urgent content to
/// screen readers, such as life-threatening allergies or critical safety warnings.
/// </summary>
/// <example>
/// <code>
/// &lt;MedicalRecordRedBox.md label="Critical allergy"&gt;
///     &lt;p&gt;Patient has a life-threatening allergy to latex.&lt;/p&gt;
/// &lt;/MedicalRecordRedBox.md&gt;
/// </code>
/// </example>
public partial class MedicalRecordRedBox : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "medica-record-red-box" : $"medica-record-red-box {CssClass}";
}
