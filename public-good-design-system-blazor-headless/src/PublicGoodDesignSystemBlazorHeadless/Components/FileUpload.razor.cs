using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A file upload component provides a button-triggered file picker for uploading files. It combines
/// a hidden file input with a visible button and a live status region that announces how many files
/// have been selected. This pattern is useful for document uploads, image uploads, or any form that
/// accepts file attachments.
/// </summary>
/// <example>
/// <code>
/// &lt;FileUpload label="Upload files" accept=".pdf" onchange=@handleFiles /&gt;
/// </code>
/// </example>
public partial class FileUpload : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Accept { get; set; }
    [Parameter] public bool Multiple { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "file-upload" : $"file-upload {CssClass}";
}
