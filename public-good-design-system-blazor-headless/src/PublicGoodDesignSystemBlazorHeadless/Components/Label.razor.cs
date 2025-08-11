using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A label is a UI component that provides a descriptive name or instruction for an associated form
/// element, such as an input field, checkbox, or radio button. The Label component renders a
/// semantic `&lt;label&gt;` HTML element that can be linked to a form control via the `for`
/// attribute, enabling click-to-focus behavior and improving accessibility for screen reader users.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Label linked to a form control by ID --&gt;
/// &lt;Label for="email"&gt;Email address&lt;/Label&gt;
/// &lt;input id="email" type="email" /&gt;
/// 
/// &lt;!-- Label wrapping a form control (no for attribute needed) --&gt;
/// &lt;Label&gt;
///   Email address
///   &lt;input type="email" /&gt;
/// &lt;/Label&gt;
/// </code>
/// </example>
public partial class Label : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    [Parameter] public string? ForId { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "label" : $"label {CssClass}";
}
