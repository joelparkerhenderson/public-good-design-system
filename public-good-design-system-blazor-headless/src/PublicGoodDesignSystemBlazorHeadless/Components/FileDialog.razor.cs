using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A file dialog provides a modal dialog for file-related operations such as opening, saving, or
/// managing files. It renders a native `&lt;dialog&gt;` element conditionally based on its `open`
/// state, with accessible labelling and keyboard dismissal support.
/// </summary>
/// <example>
/// <code>
/// &lt;FileDialog label="Open file" @bind-Open&gt;
///   &lt;ul&gt;
///     &lt;li&gt;document.txt&lt;/li&gt;
///     &lt;li&gt;image.png&lt;/li&gt;
///   &lt;/ul&gt;
///   &lt;button @onclick="HandleClick"&gt;Cancel&lt;/button&gt;
/// &lt;/FileDialog&gt;
/// </code>
/// </example>
public partial class FileDialog : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "file-dialog" : $"file-dialog {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Open = false;
            await OpenChanged.InvokeAsync(false);
        }
    }
}
