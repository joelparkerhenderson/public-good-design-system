using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tooltip is a headless component that displays brief, contextual information when made visible.
/// It uses `role="tooltip"` for semantic identification and is designed to be linked to a trigger
/// element via `aria-describedby`, providing supplementary text that screen readers can announce.
/// </summary>
/// <example>
/// <code>
/// &lt;button aria-describedby="tip"
///   onmouseenter={() =&gt; showTip = true}
///   onmouseleave={() =&gt; showTip = false}
///   onfocusin={() =&gt; showTip = true}
///   onfocusout={() =&gt; showTip = false}
/// &gt;
///   Hover me
/// &lt;/button&gt;
/// &lt;Tooltip id="tip" label="Additional info" @bind-Visible="showTip" /&gt;
/// </code>
/// </example>
public partial class Tooltip : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Visible { get; set; }
    [Parameter] public EventCallback<bool> VisibleChanged { get; set; }
    [Parameter] public string? Id { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tooltip" : $"tooltip {CssClass}";
}
