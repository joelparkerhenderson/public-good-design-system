using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A progress bar visually indicates the completion status of a task or process using the native
/// HTML `&lt;progress&gt;` element. It is commonly used for file uploads, form submissions, loading
/// sequences, installation wizards, and any process where users benefit from knowing how much of a
/// task has been completed.
/// </summary>
/// <example>
/// <code>
/// &lt;Progress label="Upload progress" value=@50 max=@100 /&gt;
/// </code>
/// </example>
public partial class Progress : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "progress" : $"progress {CssClass}";
}
