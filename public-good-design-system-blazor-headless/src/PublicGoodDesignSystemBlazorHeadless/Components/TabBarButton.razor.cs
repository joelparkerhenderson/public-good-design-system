using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tab bar button is a single tab within a tabbed interface. It renders a `&lt;button&gt;` with
/// `role="tab"` and appropriate ARIA attributes for tab selection and panel association. It follows
/// the roving tabindex pattern where only the selected tab participates in the tab order.
/// </summary>
/// <example>
/// <code>
/// &lt;TabBar label="Settings"&gt;
///   &lt;TabBarButton
///     selected={activeTab === "general"}
///     controls="panel-general"
///     @onclick="HandleClick"
///   &gt;General&lt;/TabBarButton&gt;
///   &lt;TabBarButton
///     selected={activeTab === "advanced"}
///     controls="panel-advanced"
///     @onclick="HandleClick"
///   &gt;Advanced&lt;/TabBarButton&gt;
/// &lt;/TabBar&gt;
/// </code>
/// </example>
public partial class TabBarButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Selected { get; set; }
    [Parameter] public string Controls { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tab-bar-button" : $"tab-bar-button {CssClass}";
}
