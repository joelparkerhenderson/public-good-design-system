using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A progress spinner indicates an ongoing loading or processing state where the completion time is
/// unknown. Unlike ProgressCircle which shows a specific percentage, a spinner indicates
/// indeterminate loading. It uses `role="status"` and `aria-live="polite"` to announce the loading
/// state to screen readers without interrupting the user. The component is headless, allowing
/// consumers to apply their own spinning animation via CSS.
/// </summary>
/// <example>
/// <code>
/// &lt;ProgressSpinner label="Loading data" /&gt;
/// </code>
/// </example>
public partial class ProgressSpinner : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "progress-spinner" : $"progress-spinner {CssClass}";
}
