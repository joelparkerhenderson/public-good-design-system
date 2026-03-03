using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A field component wraps a form control with its label, description, and error message, providing
/// proper labelling via `for` attribute linking and accessible error announcements. It serves as a
/// generic form field container that works with any input type -- text inputs, selects, textareas,
/// checkboxes, and more.
/// </summary>
/// <example>
/// <code>
/// &lt;Field label="Name" description="Enter full name"&gt;
///   &lt;input id="name-input" /&gt;
/// &lt;/Field&gt;
/// </code>
/// </example>
public partial class Field : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Description { get; set; }
    [Parameter] public string? Error { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public string? InputId { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "field" : $"field {CssClass}";
}
