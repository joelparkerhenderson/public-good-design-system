using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// RadioGroup is a headless fieldset container that groups related radio buttons under the ARIA
/// `radiogroup` role. It provides an accessible label for the entire group, enabling screen readers
/// and assistive technologies to communicate the relationship between individual radio buttons.
/// </summary>
/// <example>
/// <code>
/// &lt;RadioGroup label="Size"&gt;
///   &lt;label&gt;&lt;input type="radio" name="size" value="s" /&gt; Small&lt;/label&gt;
///   &lt;label&gt;&lt;input type="radio" name="size" value="m" /&gt; Medium&lt;/label&gt;
/// &lt;/RadioGroup&gt;
/// </code>
/// </example>
public partial class RadioGroup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "radio-group" : $"radio-group {CssClass}";
}
