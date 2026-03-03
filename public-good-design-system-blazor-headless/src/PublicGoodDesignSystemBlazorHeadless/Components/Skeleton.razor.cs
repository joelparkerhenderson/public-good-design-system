using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A skeleton is a loading placeholder that indicates content is in the process of loading. It
/// shows the approximate layout of content before it loads, reducing perceived loading time and
/// preventing layout shift. The component uses `aria-hidden="true"` to hide the placeholder from
/// screen readers and `aria-busy="true"` to signal that the region is being updated. The component
/// is headless, allowing consumers to style the placeholder shapes with their own CSS.
/// </summary>
/// <example>
/// <code>
/// &lt;Skeleton /&gt;
/// </code>
/// </example>
public partial class Skeleton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "skeleteon" : $"skeleteon {CssClass}";
}
