using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A context menu provides a list of actions relevant to the current context, typically triggered
/// by a right-click or long-press. The menu appears near the pointer and offers contextual options
/// such as cut, copy, paste, or custom actions.
/// </summary>
/// <example>
/// <code>
/// &lt;ContextMenu label="Actions" @bind-Open&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Cut&lt;/li&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Copy&lt;/li&gt;
///   &lt;li role="menuitem" tabindex="-1"&gt;Paste&lt;/li&gt;
/// &lt;/ContextMenu&gt;
/// </code>
/// </example>
public partial class ContextMenu : ComponentBase
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

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "context-menu" : $"context-menu {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "menuitem", "vertical");
    }
}
