using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A United States Social Security Number (SSN) input is a specialized form field for entering a
/// 9-digit SSN issued by the Social Security Administration. The SSN is used as a national
/// identifier for taxation, credit reporting, and various government and private-sector purposes.
/// </summary>
/// <example>
/// <code>
/// &lt;UnitedStatesSocialSecurityNumberInput label="Social Security Number" /&gt;
/// </code>
/// </example>
public partial class UnitedStatesSocialSecurityNumberInput : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private string SsnPattern => "[0-9]{3}-[0-9]{2}-[0-9]{4}";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "united-states-social-security-number-input" : $"united-states-social-security-number-input {CssClass}";
}
