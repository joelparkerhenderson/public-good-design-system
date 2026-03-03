using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A sonner is a component that serves as a toast notification region, providing a designated area
/// where brief, non-intrusive messages appear to inform users of events, confirmations, or status
/// updates. Commonly used for success confirmations, error alerts, progress updates, and system
/// messages, the sonner displays transient notifications that appear and automatically dismiss
/// after a short duration without requiring user interaction.
/// </summary>
/// <example>
/// <code>
/// &lt;Sonner label="Notifications"&gt;
///     &lt;div role="status"&gt;File saved successfully.&lt;/div&gt;
/// &lt;/Sonner&gt;
/// </code>
/// </example>
public partial class Sonner : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "sonner" : $"sonner {CssClass}";
}
