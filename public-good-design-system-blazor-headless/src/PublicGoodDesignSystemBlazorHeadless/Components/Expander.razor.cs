using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An expander shows or hides additional content with a toggle button control. It is similar to a
/// native `&lt;details&gt;`/`&lt;summary&gt;` disclosure element but uses a `&lt;button&gt;`
/// trigger with `aria-expanded` for full control over behavior and presentation.
/// </summary>
/// <example>
/// <code>
/// &lt;Expander label="Show details" @bind-Expanded&gt;
///   &lt;p&gt;Details here...&lt;/p&gt;
/// &lt;/Expander&gt;
/// </code>
/// </example>
public partial class Expander : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Expanded { get; set; }
    [Parameter] public EventCallback<bool> ExpandedChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "expander" : $"expander {CssClass}";
}
