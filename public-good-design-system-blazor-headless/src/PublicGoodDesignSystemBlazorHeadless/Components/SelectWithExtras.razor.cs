using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// SelectWithExtras is a headless enhanced select component that wraps a native `&lt;select&gt;`
/// element with optional content areas before and after it. This allows consumers to place
/// supplementary elements such as icons, flags, status indicators, or helper text alongside the
/// select without breaking its accessibility.
/// </summary>
/// <example>
/// <code>
/// &lt;SelectWithExtras label="Country" @bind-Value&gt;
///   {#snippet before()}&lt;span&gt;Flag:&lt;/span&gt;{/snippet}
///   &lt;option value="us"&gt;USA&lt;/option&gt;
///   &lt;option value="uk"&gt;United Kingdom&lt;/option&gt;
/// &lt;/SelectWithExtras&gt;
/// </code>
/// </example>
public partial class SelectWithExtras : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string? Value { get; set; } = "";
    [Parameter] public EventCallback<string> ValueChanged { get; set; }
    [Parameter] public bool Required { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public string Before { get; set; } = "";
    [Parameter] public string After { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "select-with-extras" : $"select-with-extras {CssClass}";
}
