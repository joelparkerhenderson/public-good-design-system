using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A postal code view displays a postal or ZIP code as read-only text within a `&lt;span&gt;`
/// element. It is used to present postal code information in address displays, confirmation pages,
/// shipping summaries, or any context where the value is not editable.
/// </summary>
/// <example>
/// <code>
/// &lt;PostalCodeView text="90210" /&gt;
/// </code>
/// </example>
public partial class PostalCodeView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Text { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "postal-code-view" : $"postal-code-view {CssClass}";
}
