using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A CheckList is a semantic list container for CheckList items, allowing users to track and manage
/// tasks, options, or steps by marking items as completed or pending. Typically displayed as a list
/// of actionable items, each with a checkbox that users can tick off as they progress, CheckLists
/// are commonly used in to-do lists, forms, or onboarding processes.
/// </summary>
/// <example>
/// <code>
/// &lt;CheckList label="Onboarding tasks"&gt;
///   &lt;li&gt;&lt;input type="checkbox" /&gt; Create account&lt;/li&gt;
///   &lt;li&gt;&lt;input type="checkbox" /&gt; Set up profile&lt;/li&gt;
///   &lt;li&gt;&lt;input type="checkbox" /&gt; Invite team members&lt;/li&gt;
/// &lt;/CheckList&gt;
/// </code>
/// </example>
public partial class CheckList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "check-list" : $"check-list {CssClass}";
}
