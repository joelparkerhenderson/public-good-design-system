using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A headless container for the center main content section of a GrailLayout.
/// </summary>
public partial class GrailLayoutCenterMain : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "grail-layout-center-main" : $"grail-layout-center-main {CssClass}";
}
