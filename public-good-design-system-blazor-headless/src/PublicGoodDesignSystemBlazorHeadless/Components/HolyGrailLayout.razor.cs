using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// The Holy Grail layout is a classic web design pattern featuring a header, footer, main content
/// area, and two sidebars. This component provides a minimal wrapper `&lt;div&gt;` that expects
/// consumers to supply semantic HTML landmark elements -- `&lt;header&gt;`, `&lt;nav&gt;`,
/// `&lt;main&gt;`, `&lt;aside&gt;`, and `&lt;footer&gt;` -- as children.
/// </summary>
/// <example>
/// <code>
/// &lt;HolyGrailLayout&gt;
///   &lt;header&gt;Site Header&lt;/header&gt;
///   &lt;nav&gt;Navigation&lt;/nav&gt;
///   &lt;main&gt;Main Content&lt;/main&gt;
///   &lt;aside&gt;Sidebar&lt;/aside&gt;
///   &lt;footer&gt;Site Footer&lt;/footer&gt;
/// &lt;/HolyGrailLayout&gt;
/// </code>
/// </example>
public partial class HolyGrailLayout : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "holy-grail-layout" : $"holy-grail-layout {CssClass}";
}
