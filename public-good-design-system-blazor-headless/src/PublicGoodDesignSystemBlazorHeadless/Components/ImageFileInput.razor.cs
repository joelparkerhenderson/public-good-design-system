using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An image input provides a file upload control that is pre-configured to accept image files. It
/// wraps a native `&lt;input type="file"&gt;` element with accessible labeling and sensible
/// defaults for image selection. This component is useful for profile photo uploads, gallery image
/// selection, document scanning, and any form that requires image file input.
/// </summary>
/// <example>
/// <code>
/// &lt;ImageFileInput label="Upload profile photo" /&gt;
/// </code>
/// </example>
public partial class ImageFileInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Accept { get; set; } = "image/*";
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "image-file-input" : $"image-file-input {CssClass}";
}
