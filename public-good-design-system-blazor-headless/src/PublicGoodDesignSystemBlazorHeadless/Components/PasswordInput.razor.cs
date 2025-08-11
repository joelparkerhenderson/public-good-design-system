using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A password input wraps a native <c>&lt;input type="password"&gt;</c> element with accessible
/// labelling and two-way data binding. The input includes <c>autocomplete="current-password"</c>
/// by default for proper browser password manager integration. It supports required and disabled
/// states.
/// </summary>
/// <example>
/// <code>
/// &lt;PasswordInput Label="Password" @bind-Value /&gt;
/// </code>
/// </example>
public partial class PasswordInput : ComponentBase
{
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string Autocomplete { get; set; } = "current-password";
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string? CssClass { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "password-input" : $"password-input {CssClass}";
}
