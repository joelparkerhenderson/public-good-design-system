using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A display component for showing a United States Social Security Number (SSN) in a read-only
/// format. The SSN is a 9-digit identifier issued by the Social Security Administration, used for
/// taxation, credit reporting, and various government and private-sector purposes.
/// </summary>
/// <example>
/// <code>
/// &lt;UnitedStatesSocialSecurityNumberView label="SSN" value="123-45-6789" /&gt;
/// </code>
/// </example>
public partial class UnitedStatesSocialSecurityNumberView : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "united-states-social-security-number-view" : $"united-states-social-security-number-view {CssClass}";
}
