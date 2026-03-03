using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A timer is a UI/UX component that displays a countdown or elapsed time value in a live-updating
/// format. It renders as a semantic HTML `&lt;time&gt;` element with `role="timer"` and
/// `aria-live="polite"` to ensure screen readers announce updates without interrupting the user.
/// The component is commonly used for session timeouts, countdowns, stopwatches, cooking timers,
/// exam time limits, and any scenario where users need to track the passage of time. This headless
/// component provides the semantic structure and accessibility features while the consumer manages
/// the actual timer logic and provides formatted display content through the children snippet.
/// </summary>
/// <example>
/// <code>
/// &lt;Timer label="Countdown"&gt;05:30&lt;/Timer&gt;
/// </code>
/// </example>
public partial class Timer : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "timer" : $"timer {CssClass}";
}
