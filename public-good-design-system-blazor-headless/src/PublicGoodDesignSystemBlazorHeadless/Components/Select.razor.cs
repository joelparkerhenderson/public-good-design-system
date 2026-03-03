using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A select is a headless component that wraps the native HTML `&lt;select&gt;` element, providing
/// a dropdown menu for choosing one option from a list. It is commonly used in forms for selecting
/// a country, category, status, or any other value from a predefined set of choices.
/// </summary>
/// <example>
/// <code>
/// &lt;Select label="Country" @bind-Value&gt;
///   &lt;option value="us"&gt;United States&lt;/option&gt;
///   &lt;option value="uk"&gt;United Kingdom&lt;/option&gt;
/// &lt;/Select&gt;
/// </code>
/// </example>
public partial class Select : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "select" : $"select {CssClass}";
}
