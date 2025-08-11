using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An icon is a compact visual element that represents actions, objects, or concepts using
/// simplified graphical symbols. The Icon component provides a headless wrapper around icon content
/// with proper accessibility semantics, supporting both meaningful icons (with accessible labels)
/// and decorative icons (hidden from assistive technology).
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Meaningful icon with accessible label --&gt;
/// &lt;Icon label="Close"&gt;x&lt;/Icon&gt;
/// 
/// &lt;!-- Decorative icon hidden from screen readers --&gt;
/// &lt;Icon decorative&gt;*&lt;/Icon&gt;
/// 
/// &lt;!-- Icon with custom attributes --&gt;
/// &lt;Icon label="Search" data-testid="search-icon"&gt;Q&lt;/Icon&gt;
/// </code>
/// </example>
public partial class Icon : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Decorative { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "icon" : $"icon {CssClass}";
}
