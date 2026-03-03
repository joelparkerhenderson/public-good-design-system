using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single task item within a task list, rendering a semantic `&lt;li&gt;` element containing a
/// checkbox input and label. Supports checked and disabled states for to-do lists, CheckLists, and
/// task trackers. The checked state is bindable for reactive completion tracking.
/// </summary>
/// <example>
/// <code>
/// &lt;ul aria-label="Today's tasks" role="list"&gt;
///     &lt;TaskListItem label="Review pull request" /&gt;
///     &lt;TaskListItem label="Update documentation" checked /&gt;
///     &lt;TaskListItem label="Deploy to staging" /&gt;
/// &lt;/ul&gt;
/// 
/// &lt;!-- Bindable checked state --&gt;
/// &lt;TaskListItem label="Accept terms" @bind-Checked="termsAccepted" /&gt;
/// </code>
/// </example>
public partial class TaskListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Checked { get; set; }
    [Parameter] public EventCallback<bool> CheckedChanged { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "task-list-item" : $"task-list-item {CssClass}";
}
