using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A task list is a UI/UX component that organizes and displays a series of tasks, actions, or
/// to-dos for users to complete. It is typically presented as a CheckList, where each task can be
/// marked as completed or remain pending. Task lists are commonly used in project management tools,
/// to-do apps, or onboarding processes to guide users through a sequence of actions. They help
/// improve productivity by breaking down complex workflows into manageable steps, offering clear
/// progress tracking. Effective task list design includes features like task prioritization, due
/// dates, and visual indicators (such as checkboxes or progress bars) to enhance user clarity and
/// motivation.
/// </summary>
/// <example>
/// <code>
/// &lt;TaskList label="Today's tasks"&gt;
///   &lt;li&gt;Review pull requests&lt;/li&gt;
///   &lt;li&gt;Update documentation&lt;/li&gt;
///   &lt;li&gt;Deploy to staging&lt;/li&gt;
/// &lt;/TaskList&gt;
/// </code>
/// </example>
public partial class TaskList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "task-list" : $"task-list {CssClass}";
}
