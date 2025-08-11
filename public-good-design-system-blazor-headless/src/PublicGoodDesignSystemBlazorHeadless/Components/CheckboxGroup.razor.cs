using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// CheckboxGroup is a headless fieldset container that groups related checkboxes under the ARIA
/// `group` role. It manages a collection of checkboxes with shared state, supporting a "Select all"
/// checkbox with automatic indeterminate state, group-level disabled state, and two-way binding of
/// selected values.
/// </summary>
/// <example>
/// <code>
/// &lt;CheckboxGroup Label="Features"&gt;
///   &lt;label&gt;&lt;input type="checkbox" name="features" value="wifi" /&gt; Wi-Fi&lt;/label&gt;
///   &lt;label&gt;&lt;input type="checkbox" name="features" value="bluetooth" /&gt; Bluetooth&lt;/label&gt;
/// &lt;/CheckboxGroup&gt;
/// </code>
/// </example>
public partial class CheckboxGroup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "checkbox-group" : $"checkbox-group {CssClass}";
}
