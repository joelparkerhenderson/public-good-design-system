using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A PIN input is a specialized form component that presents a series of single-character input
/// fields for entering Personal Identification Numbers (PINs), verification codes, one-time
/// passwords (OTPs), or similar short numeric codes. Each digit occupies its own input field,
/// creating a segmented entry experience that clearly communicates the expected code length to the
/// user.
/// </summary>
/// <example>
/// <code>
/// &lt;PinInputDiv label="Enter PIN" @bind-Value="pin" /&gt;
/// &lt;p&gt;Entered PIN: @pin&lt;/p&gt;
/// </code>
/// </example>
public partial class PinInputDiv : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public int Length { get; set; } = 4;
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private ElementReference _elementRef;

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "pin-input-div" : $"pin-input-div {CssClass}";
}
