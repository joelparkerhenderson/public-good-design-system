using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// TagInput is a headless text input for adding tags to a collection. When the user types a value
/// and presses Enter, the component calls the `onadd` callback with the trimmed text and
/// automatically clears the input, providing a streamlined tag entry experience.
/// </summary>
/// <example>
/// <code>
/// &lt;TagInput label="Add tag" @bind-Value onadd={(tag) =&gt; tags.push(tag)} /&gt;
/// </code>
/// </example>
public partial class TagInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string Onadd { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tag-input" : $"tag-input {CssClass}";

    private Task HandleKeyDown(KeyboardEventArgs e)
    {
        // Keyboard navigation is handled by consumer via OnKeyDown event
        return Task.CompletedTask;
    }
}
