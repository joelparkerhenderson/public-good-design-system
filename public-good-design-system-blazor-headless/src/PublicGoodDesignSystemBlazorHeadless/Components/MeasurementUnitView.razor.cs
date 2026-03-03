using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A measurement unit view displays a measurement unit in a `&lt;span&gt;` element. A measurement
/// unit is a standard quantity used to express a measurement, such as "kg", "lb", "cm", or "inch".
/// This component is part of the Input/View pattern for measurement data, providing a read-only
/// display of unit abbreviations or names.
/// </summary>
/// <example>
/// <code>
/// &lt;MeasurementUnitView value="kg" /&gt;
/// &lt;MeasurementUnitView value="lb" label="Pounds" /&gt;
/// </code>
/// </example>
public partial class MeasurementUnitView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "measurement-unit-view" : $"measurement-unit-view {CssClass}";
}
