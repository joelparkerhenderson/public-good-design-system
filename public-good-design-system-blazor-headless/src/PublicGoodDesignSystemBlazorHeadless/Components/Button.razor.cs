using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A button is a fundamental UI/UX component that allows users to trigger an action or event within
/// an interface, such as submitting a form, navigating to another page, or opening a menu. Buttons
/// are essential for guiding users through tasks, providing clear feedback on actions, and
/// enhancing the overall user experience by offering intuitive, actionable controls.
/// </summary>
/// <example>
/// <code>
/// &lt;Button @onclick="handleClick"&gt;Click me&lt;/Button&gt;
/// </code>
/// </example>
public partial class Button : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Type { get; set; } = "button";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public bool Pressed { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "button" : $"button {CssClass}";
}
