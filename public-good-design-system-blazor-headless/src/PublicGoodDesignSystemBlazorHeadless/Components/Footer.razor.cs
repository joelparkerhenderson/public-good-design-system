using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A footer is a semantic page landmark located at the bottom of a web page or section, typically
/// used to provide secondary navigation, legal information, contact details, and links to important
/// but less prominent content like privacy policies, terms of service, or social media profiles.
/// </summary>
/// <example>
/// <code>
/// &lt;Footer label="Site footer"&gt;
///   &lt;p&gt;Copyright 2024&lt;/p&gt;
/// &lt;/Footer&gt;
/// </code>
/// </example>
public partial class Footer : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "footer" : $"footer {CssClass}";
}
