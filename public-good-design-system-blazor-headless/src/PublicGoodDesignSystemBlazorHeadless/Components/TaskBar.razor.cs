using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A task bar is a toolbar container for task-related action buttons using the ARIA toolbar role.
/// It provides ArrowLeft/ArrowRight keyboard navigation between items with Home/End keys to jump to
/// first/last items, implementing the roving focus pattern.
/// </summary>
/// <example>
/// <code>
/// &lt;TaskBar label="Tasks"&gt;
///   &lt;TaskBarButton&gt;New&lt;/TaskBarButton&gt;
///   &lt;TaskBarButton&gt;Open&lt;/TaskBarButton&gt;
///   &lt;TaskBarButton&gt;Save&lt;/TaskBarButton&gt;
/// &lt;/TaskBar&gt;
/// </code>
/// </example>
public partial class TaskBar : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "task-bar" : $"task-bar {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "", "horizontal");
    }
}
