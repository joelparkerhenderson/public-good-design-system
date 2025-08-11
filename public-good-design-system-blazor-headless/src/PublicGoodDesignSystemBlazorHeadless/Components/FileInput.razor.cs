using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A file input wraps a native `&lt;input type="file"&gt;` element with accessible labelling. It
/// allows users to select one or more files from their device for upload. The component supports
/// filtering by accepted file types, multiple file selection, and standard form states.
/// </summary>
/// <example>
/// <code>
/// &lt;FileInput label="Upload photo" accept="image/*" /&gt;
/// </code>
/// </example>
public partial class FileInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Accept { get; set; }
    [Parameter] public bool Multiple { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "file-input" : $"file-input {CssClass}";
}
