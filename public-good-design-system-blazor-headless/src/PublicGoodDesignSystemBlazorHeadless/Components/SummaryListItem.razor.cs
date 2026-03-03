using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// SummaryListItem is a single key-value row within a SummaryList. It renders a `&lt;div&gt;`
/// wrapper containing a `&lt;dt&gt;` (term) and `&lt;dd&gt;` (description) pair. The HTML
/// specification permits `&lt;div&gt;` as a direct child of `&lt;dl&gt;` for grouping
/// `&lt;dt&gt;`/`&lt;dd&gt;` pairs, which enables per-row styling and attribute targeting.
/// </summary>
/// <example>
/// <code>
/// &lt;SummaryList label="Order summary"&gt;
///   &lt;SummaryListItem term="Product"&gt;Widget&lt;/SummaryListItem&gt;
///   &lt;SummaryListItem term="Quantity"&gt;3&lt;/SummaryListItem&gt;
///   &lt;SummaryListItem term="Total"&gt;$29.97&lt;/SummaryListItem&gt;
/// &lt;/SummaryList&gt;
/// </code>
/// </example>
public partial class SummaryListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Term { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "summary-list-item" : $"summary-list-item {CssClass}";
}
