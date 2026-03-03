using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A submit input is a UI/UX component that provides a form submission button using the native HTML
/// `&lt;input type="submit"&gt;` element. When clicked within a form, it triggers the form's submit
/// event. The component supports custom button text through the value prop and can be disabled to
/// prevent premature submission.
/// </summary>
/// <example>
/// <code>
/// &lt;SubmitInput /&gt;
/// </code>
/// </example>
public partial class SubmitInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Value { get; set; } = "Submit";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "submit-input" : $"submit-input {CssClass}";
}
