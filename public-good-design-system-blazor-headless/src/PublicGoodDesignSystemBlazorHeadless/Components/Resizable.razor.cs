using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// Resizable is a headless container that allows users to resize its contents in one or both
/// directions. It provides a focusable region with an accessible label, enabling keyboard users to
/// interact with the resizable area.
/// </summary>
/// <example>
/// <code>
/// &lt;Resizable label="Resizable panel" direction="both"&gt;
///   &lt;p&gt;Content&lt;/p&gt;
/// &lt;/Resizable&gt;
/// </code>
/// </example>
public partial class Resizable : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Direction { get; set; } = "both";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "resizable" : $"resizable {CssClass}";
}
