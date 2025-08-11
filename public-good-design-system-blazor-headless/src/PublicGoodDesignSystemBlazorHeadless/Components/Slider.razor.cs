using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A slider is a UI/UX component that allows users to select a numeric value by dragging a handle
/// along a track, typically used for adjusting settings like volume, brightness, price ranges, or
/// timelines. It provides an intuitive and interactive way to input data within a defined minimum
/// and maximum range.
/// </summary>
/// <example>
/// <code>
/// &lt;Slider label="Volume" @bind-Value min=@0 max=@100 step=@5 /&gt;
/// </code>
/// </example>
public partial class Slider : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int Value { get; set; } = 50;
    [Parameter] public EventCallback<int> ValueChanged { get; set; }
    [Parameter] public int Min { get; set; }
    [Parameter] public int Max { get; set; } = 100;
    [Parameter] public int Step { get; set; } = 1;
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "slider" : $"slider {CssClass}";
}
