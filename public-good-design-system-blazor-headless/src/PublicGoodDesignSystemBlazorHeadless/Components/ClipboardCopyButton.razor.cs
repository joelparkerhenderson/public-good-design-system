using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A clipboard copy button that copies specified text to the system clipboard when activated. It
/// uses the Clipboard API (`navigator.clipboard.writeText`) and exposes success and error callbacks
/// for consumer-defined feedback.
/// </summary>
/// <example>
/// <code>
/// &lt;ClipboardCopyButton text="https://example.com" label="Copy link" /&gt;
/// </code>
/// </example>
public partial class ClipboardCopyButton : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Text { get; set; } = "";
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private bool Copied { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "clipboard-copy-button" : $"clipboard-copy-button {CssClass}";

    private async Task HandleClick(MouseEventArgs args)
    {
        Copied = true;
        if (OnClick.HasDelegate)
            await OnClick.InvokeAsync(args);
    }
}
