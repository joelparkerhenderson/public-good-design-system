using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A panel is a UI component that serves as a labeled container for grouping related content,
/// controls, or settings within an interface. The Panel component renders a semantic
/// `&lt;section&gt;` element with an accessible label, creating a named region landmark that
/// assistive technology can identify and navigate to.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Basic panel with labeled region --&gt;
/// &lt;Panel label="Settings"&gt;
///   &lt;p&gt;Adjust your preferences below.&lt;/p&gt;
/// &lt;/Panel&gt;
/// 
/// &lt;!-- Multiple panels on a page --&gt;
/// &lt;Panel label="Account information"&gt;
///   &lt;p&gt;Name, email, and profile details.&lt;/p&gt;
/// &lt;/Panel&gt;
/// &lt;Panel label="Notification preferences"&gt;
///   &lt;p&gt;Choose how you want to be notified.&lt;/p&gt;
/// &lt;/Panel&gt;
/// </code>
/// </example>
public partial class Panel : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "panel" : $"panel {CssClass}";
}
