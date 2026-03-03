using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An email address view displays an email as a clickable mailto link. When clicked, it opens the
/// user's default email client with the address pre-filled. This is the read-only companion to
/// EmailAddressInput, used for displaying email addresses in profiles, contact lists, or user
/// cards.
/// </summary>
/// <example>
/// <code>
/// &lt;EmailLink email="alice@example.com" /&gt;
/// </code>
/// </example>
public partial class EmailLink : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Email { get; set; } = "";
    [Parameter] public string? Label { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "email-link" : $"email-link {CssClass}";
}
