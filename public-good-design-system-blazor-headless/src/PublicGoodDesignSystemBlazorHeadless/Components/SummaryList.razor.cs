using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A summary list is a component that presents a concise overview of key information as key-value
/// pairs, typically in a structured, easy-to-scan format. It is often used to summarize important
/// details such as transaction history, order details, product features, account settings, or form
/// review data in a description list layout.
/// </summary>
/// <example>
/// <code>
/// &lt;SummaryList label="Order summary"&gt;
///     &lt;dt&gt;Product&lt;/dt&gt;&lt;dd&gt;Widget&lt;/dd&gt;
///     &lt;dt&gt;Quantity&lt;/dt&gt;&lt;dd&gt;3&lt;/dd&gt;
///     &lt;dt&gt;Total&lt;/dt&gt;&lt;dd&gt;$29.97&lt;/dd&gt;
/// &lt;/SummaryList&gt;
/// </code>
/// </example>
public partial class SummaryList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "summary-list" : $"summary-list {CssClass}";
}
