using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A textarea is a headless component that wraps the native HTML `&lt;textarea&gt;` element,
/// providing a multi-line text input area. It is commonly used in forms for comments, messages,
/// descriptions, feedback, code input, and any scenario where users need to enter extended text
/// content.
/// </summary>
/// <example>
/// <code>
/// &lt;Textarea label="Comments" @bind-Value rows=@5 /&gt;
/// </code>
/// </example>
public partial class Textarea : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Rows { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "textarea" : $"textarea {CssClass}";
}
