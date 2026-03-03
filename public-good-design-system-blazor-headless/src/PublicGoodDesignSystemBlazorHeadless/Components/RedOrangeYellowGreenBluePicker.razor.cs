using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A ROYGB (Red/Orange/Yellow/Green/Blue) status input is a UI/UX component that allows users to
/// select a five-level color-coded status value from a dropdown. ROYGB extends the traditional RAG
/// (Red/Amber/Green) model by adding orange and blue levels for more granular status reporting. Red
/// indicates a critical problem, orange signals a hazard or significant risk, yellow means caution
/// or minor issues, green indicates normal on-track status, and blue represents a paused or
/// informational state. The component renders as a select element with appropriate accessibility
/// attributes, providing native keyboard navigation and screen reader support. This headless
/// component provides the semantic structure while allowing consumers to apply their own visual
/// styling.
/// </summary>
/// <example>
/// <code>
/// &lt;RedOrangeYellowGreenBluePicker label="Risk level" @bind-Value="level" /&gt;
/// &lt;p&gt;Current level: @level&lt;/p&gt;
/// </code>
/// </example>
public partial class RedOrangeYellowGreenBluePicker : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "red-orange-yellow-green-blue-picker" : $"red-orange-yellow-green-blue-picker {CssClass}";
}
