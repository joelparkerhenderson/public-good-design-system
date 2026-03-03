using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A notification is a UI component used to deliver timely messages to users about events, updates,
/// or actions within an application. The Notification component provides a headless wrapper with
/// proper ARIA live region semantics, ensuring that screen readers announce notification content
/// when it appears. It supports both polite (non-urgent) and assertive (urgent) announcements.
/// </summary>
/// <example>
/// <code>
/// &lt;!-- Non-urgent notification (polite) --&gt;
/// &lt;Notification label="Success"&gt;Your changes have been saved.&lt;/Notification&gt;
/// 
/// &lt;!-- Urgent notification (assertive) --&gt;
/// &lt;Notification label="Error" urgent&gt;Something went wrong. Please try again.&lt;/Notification&gt;
/// 
/// &lt;!-- Notification without explicit label --&gt;
/// &lt;Notification&gt;3 new messages&lt;/Notification&gt;
/// </code>
/// </example>
public partial class Notification : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Urgent { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "notification" : $"notification {CssClass}";
}
