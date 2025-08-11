using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A popup is a UI component that temporarily appears over the main content to convey information,
/// prompt user actions, or display additional options without navigating away from the current
/// screen. The Popup component provides a headless conditional dialog overlay that renders its
/// content only when the `open` state is true, using proper dialog semantics for assistive
/// technology.
/// </summary>
/// <example>
/// <code>
/// &lt;button @onclick="HandleClick"&gt;Open popup&lt;/button&gt;
/// &lt;Popup label="Confirmation" @bind-Open="showPopup"&gt;
///   &lt;p&gt;Are you sure you want to proceed?&lt;/p&gt;
///   &lt;button @onclick="HandleClick"&gt;Yes&lt;/button&gt;
///   &lt;button @onclick="HandleClick"&gt;No&lt;/button&gt;
/// &lt;/Popup&gt;
/// </code>
/// </example>
public partial class Popup : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "popup" : $"popup {CssClass}";
}
