using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A table is a component used to display structured data in rows and columns, making it easy to
/// compare and analyze information at a glance. Commonly used for reports, schedules, product
/// lists, and dashboards, tables organize content into headers and cells to improve data
/// readability and support efficient decision-making.
/// </summary>
/// <example>
/// <code>
/// &lt;Table label="User accounts"&gt;
///     &lt;thead&gt;&lt;tr&gt;&lt;th scope="col"&gt;Name&lt;/th&gt;&lt;th scope="col"&gt;Email&lt;/th&gt;&lt;/tr&gt;&lt;/thead&gt;
///     &lt;tbody&gt;&lt;tr&gt;&lt;td&gt;Alice&lt;/td&gt;&lt;td&gt;alice@example.com&lt;/td&gt;&lt;/tr&gt;&lt;/tbody&gt;
/// &lt;/Table&gt;
/// </code>
/// </example>
public partial class Table : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "table" : $"table {CssClass}";
}
