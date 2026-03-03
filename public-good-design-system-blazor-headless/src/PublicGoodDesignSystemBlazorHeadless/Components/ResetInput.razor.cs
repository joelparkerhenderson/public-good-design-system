using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A reset input is a UI/UX component that provides a form reset button using the native HTML
/// `&lt;input type="reset"&gt;` element. When clicked within a form, it resets all form fields to
/// their initial values. The component supports custom button text through the value prop and can
/// be disabled when form resetting should be prevented.
/// </summary>
/// <example>
/// <code>
/// &lt;ResetInput /&gt;
/// </code>
/// </example>
public partial class ResetInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Value { get; set; } = "Reset";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "reset-input" : $"reset-input {CssClass}";
}
