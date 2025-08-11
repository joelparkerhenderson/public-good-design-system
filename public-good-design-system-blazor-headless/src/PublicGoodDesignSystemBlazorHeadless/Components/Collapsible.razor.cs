using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A collapsible (disclosure) component allows users to expand or collapse a section of content.
/// Built on the native HTML `&lt;details&gt;` and `&lt;summary&gt;` elements, it provides built-in
/// keyboard support and screen reader announcements without any JavaScript.
/// </summary>
/// <example>
/// <code>
/// &lt;Collapsible summary="More info"&gt;
///   &lt;p&gt;Hidden content revealed on expand.&lt;/p&gt;
/// &lt;/Collapsible&gt;
/// </code>
/// </example>
public partial class Collapsible : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Summary { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "collapsable-details" : $"collapsable-details {CssClass}";
}
