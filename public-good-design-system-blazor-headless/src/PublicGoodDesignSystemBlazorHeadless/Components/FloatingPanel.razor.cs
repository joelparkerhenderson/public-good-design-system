using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A floating panel is a container that overlays page content, typically used for tooltips,
/// popovers, dropdown menus, or contextual UI. It renders conditionally based on an `open` prop,
/// making it suitable for toggle-based visibility patterns. The component is headless, so consumers
/// are responsible for positioning the panel relative to a trigger element using their own CSS.
/// </summary>
/// <example>
/// <code>
/// &lt;FloatingPanel open=@showPanel label="Options"&gt;
///   &lt;p&gt;Panel content&lt;/p&gt;
/// &lt;/FloatingPanel&gt;
/// </code>
/// </example>
public partial class FloatingPanel : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "floating-panel" : $"floating-panel {CssClass}";
}
