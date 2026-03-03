using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A fieldset groups related form elements together using the native `&lt;fieldset&gt;` and
/// `&lt;legend&gt;` HTML elements. This provides both a visual grouping and a semantic association
/// that screen readers announce when users navigate into the group, helping them understand the
/// context of related inputs.
/// </summary>
/// <example>
/// <code>
/// &lt;Fieldset legend="Contact info"&gt;
///   &lt;label&gt;Email &lt;input type="email" /&gt;&lt;/label&gt;
///   &lt;label&gt;Phone &lt;input type="tel" /&gt;&lt;/label&gt;
/// &lt;/Fieldset&gt;
/// </code>
/// </example>
public partial class Fieldset : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Legend { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "fieldset" : $"fieldset {CssClass}";
}
