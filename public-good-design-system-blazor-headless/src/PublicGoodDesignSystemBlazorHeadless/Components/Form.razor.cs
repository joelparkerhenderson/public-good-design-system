using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A form component wraps a native HTML `&lt;form&gt;` element with accessible labeling, automatic
/// submit default prevention, and reset support. It simplifies form handling by intercepting the
/// submit event and calling `preventDefault()` before passing it to the consumer's callback, which
/// is the most common pattern in single-page applications.
/// </summary>
/// <example>
/// <code>
/// &lt;Form label="Login" onsubmit=@handleLogin&gt;
///   &lt;input name="email" /&gt;
///   &lt;button type="submit"&gt;Sign in&lt;/button&gt;
/// &lt;/Form&gt;
/// </code>
/// </example>
public partial class Form : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public EventCallback OnSubmit { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private async Task HandleSubmit()
    {
        if (OnSubmit.HasDelegate)
            await OnSubmit.InvokeAsync();
    }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "form" : $"form {CssClass}";
}
