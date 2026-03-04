using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// AiLabel is a headless inline indicator that communicates the presence of AI-generated
/// content and provides a pathway to AI explainability. It renders a &lt;span&gt; element
/// with visible text and an accessible label.
/// </summary>
/// <example>
/// <code>
/// &lt;AiLabel /&gt;
/// &lt;AiLabel Text="AI generated" Label="AI generated content" /&gt;
/// </code>
/// </example>
public partial class AiLabel : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "AI";
    [Parameter] public string Text { get; set; } = "AI";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "ai-label" : $"ai-label {CssClass}";
}
