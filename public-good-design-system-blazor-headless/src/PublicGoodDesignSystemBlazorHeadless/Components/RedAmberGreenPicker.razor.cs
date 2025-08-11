using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A RAG (Red/Amber/Green) status input is a UI/UX component that allows users to select a
/// traffic-light status value from a dropdown. RAG status is one of the most widely used status
/// indicators in project management, dashboards, and reporting tools. Red indicates a critical
/// problem that needs immediate attention, amber signals caution or minor issues, and green means
/// everything is on track. The component renders as a select element with appropriate accessibility
/// attributes, providing native keyboard navigation and screen reader support. This headless
/// component provides the semantic structure while allowing consumers to apply their own visual
/// styling.
/// </summary>
/// <example>
/// <code>
/// &lt;RedAmberGreenPicker label="Project status" @bind-Value="status" /&gt;
/// &lt;p&gt;Current status: @status&lt;/p&gt;
/// </code>
/// </example>
public partial class RedAmberGreenPicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-amber-green-picker" : $"red-amber-green-picker {CssClass}";
}
