using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A headless container for the left aside section of a GrailLayout.
/// </summary>
public partial class GrailLayoutLeftAside : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "grail-layout-left-aside" : $"grail-layout-left-aside {CssClass}";
}
