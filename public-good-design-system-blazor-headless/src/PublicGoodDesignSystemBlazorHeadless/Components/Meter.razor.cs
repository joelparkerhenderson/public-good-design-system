using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// Meter is a headless component that displays a scalar measurement within a known range using the
/// native HTML `&lt;meter&gt;` element. It provides accessible labelling and supports optional
/// threshold indicators for low, high, and optimum values.
/// </summary>
/// <example>
/// <code>
/// &lt;Meter label="Disk space" value=@45 max=@100 /&gt;
/// </code>
/// </example>
public partial class Meter : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public int Min { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public string? Low { get; set; }
    [Parameter] public string? High { get; set; }
    [Parameter] public string? Optimum { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "meter" : $"meter {CssClass}";
}
