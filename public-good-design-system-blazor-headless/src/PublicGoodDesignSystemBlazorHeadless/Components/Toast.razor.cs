using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A toast is a UI/UX component that provides a brief, transient notification message to the user.
/// It uses `role="status"` with `aria-live="polite"` by default, or `role="alert"` with
/// `aria-live="assertive"` for urgent messages. Toasts are typically displayed temporarily to
/// confirm actions, report errors, or provide status updates without requiring user interaction.
/// </summary>
/// <example>
/// <code>
/// &lt;Toast label="Success"&gt;Your changes have been saved.&lt;/Toast&gt;
/// </code>
/// </example>
public partial class Toast : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public bool Urgent { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "toast" : $"toast {CssClass}";
}
