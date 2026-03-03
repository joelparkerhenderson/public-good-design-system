using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An option component wraps the native HTML `&lt;option&gt;` element for use inside
/// `&lt;select&gt;` elements. It accepts a value prop for the form submission value and renders
/// children as the visible option label text.
/// </summary>
/// <example>
/// <code>
/// &lt;select&gt;
///   &lt;Option value="us"&gt;United States&lt;/Option&gt;
///   &lt;Option value="uk"&gt;United Kingdom&lt;/Option&gt;
/// &lt;/select&gt;
/// </code>
/// </example>
public partial class Option : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "option" : $"option {CssClass}";
}
