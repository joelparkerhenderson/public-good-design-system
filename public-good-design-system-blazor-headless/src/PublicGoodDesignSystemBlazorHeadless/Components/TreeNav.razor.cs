using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tree menu is a component that displays hierarchical or nested navigation options, often
/// represented with expandable and collapsible nodes resembling the structure of a tree. Each node
/// can contain sub-options or categories, allowing users to drill down into deeper levels of
/// content or functionality. This type of menu is particularly useful for organizing complex or
/// large datasets, file directories, or multi-level categories.
/// </summary>
/// <example>
/// <code>
/// &lt;TreeNav label="Navigation"&gt;
///     &lt;li role="treeitem" tabindex="-1"&gt;Home&lt;/li&gt;
///     &lt;li role="treeitem" tabindex="-1"&gt;About&lt;/li&gt;
///     &lt;li role="treeitem" tabindex="-1"&gt;Contact&lt;/li&gt;
/// &lt;/TreeNav&gt;
/// </code>
/// </example>
public partial class TreeNav : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tree-nav" : $"tree-nav {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "treeitem", "vertical");
    }
}
