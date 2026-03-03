using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// PasswordInputDiv is a headless component that wraps a native `&lt;input type="password"&gt;`
/// element with accessible labelling and an optional toggle button to show or hide the password
/// text. The input automatically includes `autocomplete="current-password"` for proper browser
/// password manager integration.
/// </summary>
/// <example>
/// <code>
/// &lt;PasswordInputDiv label="Password" @bind-Value /&gt;
/// </code>
/// </example>
public partial class PasswordInputDiv : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool ShowToggle { get; set; } = true;
    [Parameter] public string? ToggleLabel { get; set; } = "Show password";
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "password-input-div" : $"password-input-div {CssClass}";
}
