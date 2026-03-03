using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button representing a single predefined color choice within a ColorPicker. It allows users to
/// select a color from a set of predefined options by clicking on a visually representative swatch.
/// The component communicates selected state through `aria-pressed` and exposes `data-color` for
/// consumer CSS targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;ColorPicker label="Choose a color"&gt;
///   &lt;ColorPickerSwatchButton color="#ff0000" label="Red" @onclick="handleSelect" /&gt;
///   &lt;ColorPickerSwatchButton color="#0066cc" label="Blue" selected=@true @onclick="handleSelect" /&gt;
///   &lt;ColorPickerSwatchButton color="#cccccc" label="Gray" disabled=@true /&gt;
/// &lt;/ColorPicker&gt;
/// </code>
/// </example>
public partial class ColorPickerButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Color { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Selected { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "color-picker-button" : $"color-picker-button {CssClass}";
}
