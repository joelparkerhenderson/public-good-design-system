using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A radio input provides a bare `&lt;input type="radio"&gt;` element without a wrapping label. It
/// is designed for use in custom radio group layouts where labels are provided separately or by a
/// parent component. The component uses `aria-label` to ensure each radio button has an accessible
/// name.
/// </summary>
/// <example>
/// <code>
/// &lt;RadioInput label="Option A" name="choice" value="a" /&gt;
/// </code>
/// </example>
public partial class RadioInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Name { get; set; }
    [Parameter] public string? Value { get; set; }
    [Parameter] public bool Checked { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "radio-input" : $"radio-input {CssClass}";
}
