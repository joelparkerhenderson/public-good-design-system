using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A command palette provides a searchable list of actions or items. Users type into a search input
/// to filter and select commands via keyboard or mouse. This pattern is commonly used for
/// quick-access command palettes (e.g., Ctrl+K interfaces), searchable menus, and action launchers.
/// </summary>
/// <example>
/// <code>
/// &lt;Command label="Command palette" placeholder="Search commands..." @bind-Value="query"&gt;
///     {#each filteredCommands as cmd}
///         &lt;div role="option"&gt;{cmd.name}&lt;/div&gt;
///     {/each}
/// &lt;/Command&gt;
/// </code>
/// </example>
public partial class Command : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Placeholder { get; set; }
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "command" : $"command {CssClass}";
}
