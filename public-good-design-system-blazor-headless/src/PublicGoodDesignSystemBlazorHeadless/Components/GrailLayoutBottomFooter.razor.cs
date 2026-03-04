using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A headless container for the bottom footer section of a GrailLayout.
/// </summary>
public partial class GrailLayoutBottomFooter : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "grail-layout-bottom-footer" : $"grail-layout-bottom-footer {CssClass}";
}
