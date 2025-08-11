using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement instance view displays a specific measured value in a `&lt;span&gt;` element. A
/// measurement instance is a concrete data point such as "72 kg", "98.6 F", or "120/80 mmHg". This
/// component is part of the Input/View pattern for measurement data, providing a read-only display
/// of measurement values.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementInstanceView value="72 kg" /&gt;
/// &lt;MeasurementInstanceView value="98.6 F" label="Body temperature" /&gt;
/// </code>
/// </example>
public partial class MeasurementInstanceView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-instance-view" : $"measurement-instance-view {CssClass}";
}
