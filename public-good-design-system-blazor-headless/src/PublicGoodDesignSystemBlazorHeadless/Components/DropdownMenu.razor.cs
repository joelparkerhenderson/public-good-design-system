using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A dropdown menu triggered by a button that reveals a list of actions or options. This component
/// combines a toggle button with a menu panel, providing a compact way to present multiple actions
/// or choices without taking up permanent screen space. Common use cases include action menus,
/// settings menus, context-sensitive options, and navigation.
/// </summary>
/// <example>
/// <code>
/// &lt;DropdownMenu label="Options" @bind-Open&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Edit&lt;/li&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Duplicate&lt;/li&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Delete&lt;/li&gt;
/// &lt;/DropdownMenu&gt;
/// </code>
/// </example>
public partial class DropdownMenu : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;


    private Task HandleMenuKeydown(EventArgs e) => Task.CompletedTask;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "do-list-item" : $"do-list-item {CssClass}";

}
