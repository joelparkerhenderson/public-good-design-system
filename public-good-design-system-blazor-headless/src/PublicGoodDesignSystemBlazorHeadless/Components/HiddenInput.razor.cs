using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// HiddenInput is a headless component that renders a native `&lt;input type="hidden"&gt;` element
/// for passing data in forms that should not be visible or editable by the user. It provides a
/// simple, type-safe way to include hidden form values such as CSRF tokens, record IDs, or other
/// metadata that must be submitted with a form.
/// </summary>
/// <example>
/// <code>
/// &lt;HiddenInput name="csrf" value=@token /&gt;
/// </code>
/// </example>
public partial class HiddenInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Name { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "hidden-input" : $"hidden-input {CssClass}";
}
