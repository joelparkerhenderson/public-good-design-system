using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A combobox combines a text input with a dropdown listbox of suggestions, providing an
/// autocomplete or type-ahead search experience. Users type into the input to filter suggestions,
/// then select from matching options in the dropdown. This pattern is commonly used for search
/// fields, address inputs, tag selectors, and any scenario where users choose from a large set of
/// options.
/// </summary>
/// <example>
/// <code>
/// &lt;Combobox label="Search" @bind-Value @bind-Open&gt;
///     &lt;div role="option" tabindex="-1"&gt;Option 1&lt;/div&gt;
/// &lt;/Combobox&gt;
/// </code>
/// </example>
public partial class Combobox : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "combobox" : $"combobox {CssClass}";


    private async Task HandleInput(ChangeEventArgs e)
    {
        Value = e.Value?.ToString() ?? "";
        await ValueChanged.InvokeAsync(Value);
    }
    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Open = false;
            await OpenChanged.InvokeAsync(false);
        }
        else if (e.Key == "ArrowDown")
        {
            Open = true;
            await OpenChanged.InvokeAsync(true);
        }
    }
}
