using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.JSInterop;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// TreeNavList is a headless hierarchical list component that uses the ARIA `tree` role with full
/// keyboard navigation. It provides an accessible container for displaying nested or flat tree
/// structures such as file browsers, organizational charts, or navigation menus.
/// </summary>
/// <example>
/// <code>
/// &lt;TreeNavList label="File browser"&gt;
///   &lt;li role="treeitem" tabindex="0"&gt;Documents&lt;/li&gt;
///   &lt;li role="treeitem" tabindex="-1"&gt;Photos&lt;/li&gt;
/// &lt;/TreeNavList&gt;
/// </code>
/// </example>
public partial class TreeNavList : ComponentBase
{
    [Inject] private IJSRuntime JSRuntime { get; set; } = default!;

    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tree-nav-list" : $"tree-nav-list {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        await JSRuntime.InvokeVoidAsync("headlessInterop.handleKeyboardNav",
            _elementRef, e.Key, "treeitem", "vertical");
    }
}
