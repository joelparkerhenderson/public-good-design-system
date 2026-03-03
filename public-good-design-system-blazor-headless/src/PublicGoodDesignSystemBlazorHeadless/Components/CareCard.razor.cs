using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A care card is a healthcare-oriented component for displaying medical guidance with varying
/// levels of urgency. Inspired by the NHS England design system, care cards communicate health
/// advice in three tiers: non-urgent (speak to a GP), urgent (visit A&amp;E or call 111), and
/// immediate (call 999).
/// </summary>
/// <example>
/// <code>
/// &lt;CareCard type="non-urgent" heading="Speak to a GP if:"&gt;
///   &lt;ul&gt;&lt;li&gt;you have symptoms&lt;/li&gt;&lt;/ul&gt;
/// &lt;/CareCard&gt;
/// </code>
/// </example>
public partial class CareCard : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string? Type { get; set; } = "non-urgent";
    [Parameter] public string Heading { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "care-card" : $"care-card {CssClass}";
}
