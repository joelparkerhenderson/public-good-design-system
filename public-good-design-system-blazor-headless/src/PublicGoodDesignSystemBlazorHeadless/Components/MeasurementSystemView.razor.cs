using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement system view displays a measurement system name in a `&lt;span&gt;` element. A
/// measurement system is a collection of units and rules for measuring, such as "metric",
/// "imperial", or "SI" (International System of Units). This component is part of the Input/View
/// pattern for measurement data, providing a read-only display of measurement system names.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementSystemView value="metric" /&gt;
/// &lt;MeasurementSystemView value="SI" label="International System" /&gt;
/// </code>
/// </example>
public partial class MeasurementSystemView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-system-view" : $"measurement-system-view {CssClass}";
}
