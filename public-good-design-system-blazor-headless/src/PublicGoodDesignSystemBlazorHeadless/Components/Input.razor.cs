using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An input provides a headless text input field with accessible labeling and two-way value
/// binding. It serves as the foundational form input component for text entry, supporting various
/// HTML input types such as text, email, password, number, search, and more.
/// </summary>
/// <example>
/// <code>
/// &lt;Input label="Search" @bind-Value /&gt;
/// </code>
/// </example>
public partial class Input : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public string? Type { get; set; } = "text";
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "input" : $"input {CssClass}";
}
