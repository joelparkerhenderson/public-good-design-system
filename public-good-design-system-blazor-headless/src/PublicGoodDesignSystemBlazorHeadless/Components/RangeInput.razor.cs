using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A range input is a UI/UX component that provides a slider control for selecting a numeric value
/// within a defined range. It uses the native HTML `&lt;input type="range"&gt;` element, which
/// renders as a draggable track and handle. The component supports configurable minimum, maximum,
/// and step values, and provides a bindable value prop for two-way data binding. An aria-label
/// ensures the control is accessible to screen readers and assistive technologies.
/// </summary>
/// <example>
/// <code>
/// &lt;RangeInput label="Volume" @bind-Value min=@0 max=@100 /&gt;
/// </code>
/// </example>
public partial class RangeInput : ComponentBase
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

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "range-input" : $"range-input {CssClass}";
}
