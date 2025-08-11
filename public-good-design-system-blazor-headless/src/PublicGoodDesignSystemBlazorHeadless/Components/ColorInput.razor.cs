using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A color input wraps the native HTML `&lt;input type="color"&gt;` element, providing a
/// browser-native color picker with accessible labeling. The value is always a hex color string
/// (e.g., "#ff0000"). This component is useful in settings panels, theme editors, or any interface
/// where users need to select a color.
/// </summary>
/// <example>
/// <code>
/// &lt;ColorInput label="Background color" @bind-Value="color" /&gt;
/// </code>
/// </example>
public partial class ColorInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Value { get; set; } = "#000000";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? Name { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "color-input" : $"color-input {CssClass}";
}
