using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A date field provides a fully labeled date input with built-in support for descriptions and
/// error messages. It wraps a native `&lt;input type="date"&gt;` with a visible `&lt;label&gt;`,
/// optional helper text, and validation error display, all properly linked via generated IDs for
/// accessibility.
/// </summary>
/// <example>
/// <code>
/// &lt;DateField label="Start date" @bind-Value /&gt;
/// </code>
/// </example>
public partial class DateField : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Description { get; set; }
    [Parameter] public string? Error { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "date-field" : $"date-field {CssClass}";
}
