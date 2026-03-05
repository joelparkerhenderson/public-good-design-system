using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An image input is a UI/UX component that provides a graphical submit button using the native
/// HTML <c>&lt;input type="image"&gt;</c> element. When clicked within a form, it submits the form
/// using the specified image as the button face. The component supports source URL, alt text,
/// width, height, and disabled state.
/// </summary>
/// <example>
/// <code>
/// &lt;ImageInput Src="/submit.png" Alt="Submit" /&gt;
/// </code>
/// </example>
public partial class ImageInput : ComponentBase
{
    [Parameter] public string Src { get; set; } = "";
    [Parameter] public string Alt { get; set; } = "";
    [Parameter] public int? Width { get; set; }
    [Parameter] public int? Height { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? CssClass { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "image-input" : $"image-input {CssClass}";
}
