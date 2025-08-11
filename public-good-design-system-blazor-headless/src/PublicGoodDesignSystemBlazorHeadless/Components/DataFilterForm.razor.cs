using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A data filter component allows users to narrow down a dataset by applying criteria. It wraps
/// filter controls in a semantic `&lt;form&gt;` element with `role="search"` and accessible
/// labelling via `aria-label`. Consumers provide their own filter inputs, submit buttons, and reset
/// buttons as children.
/// </summary>
/// <example>
/// <code>
/// &lt;DataFilterForm label="Filter results" onsubmit=@applyFilters&gt;
///   &lt;label&gt;Category &lt;select&gt;...&lt;/select&gt;&lt;/label&gt;
///   &lt;button type="submit"&gt;Apply&lt;/button&gt;
/// &lt;/DataFilterForm&gt;
/// </code>
/// </example>
public partial class DataFilterForm : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public EventCallback OnSubmit { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private async Task HandleSubmit()
    {
        if (OnSubmit.HasDelegate)
            await OnSubmit.InvokeAsync();
    }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "data-filter-form" : $"data-filter-form {CssClass}";
}
