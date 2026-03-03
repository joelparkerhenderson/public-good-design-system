using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A phone number view displays a phone number as a clickable `tel:` link, allowing users on mobile
/// devices to initiate a phone call directly by tapping or clicking the number. This is part of the
/// Input/View pattern where TelLink is the read-only display counterpart.
/// </summary>
/// <example>
/// <code>
/// &lt;TelLink phone="+1-555-0100" /&gt;
/// </code>
/// </example>
public partial class TelLink : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Phone { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tel-link" : $"tel-link {CssClass}";
}
