using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A task bar button is a single button within a task bar, rendered as a native `&lt;button&gt;`
/// element for proper keyboard and screen reader support. It is designed to be placed inside a
/// TaskBar container that manages layout and grouping.
/// </summary>
/// <example>
/// <code>
/// &lt;TaskBarButton&gt;New Task&lt;/TaskBarButton&gt;
/// </code>
/// </example>
public partial class TaskBarButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "task-bar-button" : $"task-bar-button {CssClass}";
}
