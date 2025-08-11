using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An angle slider range input is a specialized range input component for selecting an angle value,
/// typically between 0 and 360 degrees. Built on the native HTML range input, it provides semantic
/// ARIA slider attributes including value text that conveys the angle with a degree symbol to
/// screen readers.
/// </summary>
/// <example>
/// <code>
/// &lt;AngleSliderRangeInput label="Rotation" @bind-Value="angle" /&gt;
/// &lt;p&gt;Angle: @angle degrees&lt;/p&gt;
/// </code>
/// </example>
public partial class AngleSliderRangeInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public int Value { get; set; } = 0;
    [Parameter] public EventCallback<int> ValueChanged { get; set; }
    [Parameter] public int Min { get; set; }
    [Parameter] public int Max { get; set; } = 360;
    [Parameter] public int Step { get; set; } = 1;
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? Name { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter] public string? ValueTextSuffix { get; set; } = "°";

    private string ValueText => $"{Value}{ValueTextSuffix}";

    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "angle-slider-rang-input" : $"angle-slider-rang-input {CssClass}";
}
