using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A signature pad provides a headless container for capturing handwritten signatures, typically
/// using mouse, touch, or stylus input. Commonly used in contract signing workflows, consent forms,
/// delivery confirmations, and legal document processing, the signature pad brings the familiar
/// pen-on-paper signing experience to digital interfaces.
/// </summary>
/// <example>
/// <code>
/// &lt;SignaturePad label="Sign to accept terms"&gt;
///   &lt;canvas width="400" height="200"&gt;&lt;/canvas&gt;
/// &lt;/SignaturePad&gt;
/// </code>
/// </example>
public partial class SignaturePad : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "signature-pad" : $"signature-pad {CssClass}";
}
