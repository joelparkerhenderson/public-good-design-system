using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tour guide list is a headless guided walkthrough overlay that presents step-by-step
/// instructions to users. It renders as a modal dialog when active and can be dismissed with the
/// Escape key, providing a structured onboarding or feature discovery experience.
/// </summary>
/// <example>
/// <code>
/// &lt;TourList label="Getting started" @bind-Active&gt;
///   &lt;TourListItem label="Welcome" current={step === 0} stepNumber=@1 totalSteps=@3&gt;
///     &lt;p&gt;Welcome to the app!&lt;/p&gt;
///     &lt;button @onclick="HandleClick"&gt;Next&lt;/button&gt;
///   &lt;/TourListItem&gt;
///   &lt;TourListItem label="Features" current={step === 1} stepNumber=@2 totalSteps=@3&gt;
///     &lt;p&gt;Here are the features.&lt;/p&gt;
///     &lt;button @onclick="HandleClick"&gt;Back&lt;/button&gt;
///     &lt;button @onclick="HandleClick"&gt;Next&lt;/button&gt;
///   &lt;/TourListItem&gt;
///   &lt;TourListItem label="Finish" current={step === 2} stepNumber=@3 totalSteps=@3&gt;
///     &lt;p&gt;You're all set!&lt;/p&gt;
///     &lt;button @onclick="HandleClick"&gt;Done&lt;/button&gt;
///   &lt;/TourListItem&gt;
/// &lt;/TourList&gt;
/// </code>
/// </example>
public partial class TourList : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Active { get; set; }
    [Parameter] public EventCallback<bool> ActiveChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tour-list" : $"tour-list {CssClass}";

    private async Task HandleKeyDown(KeyboardEventArgs e)
    {
        if (e.Key == "Escape")
        {
            Active = false;
            await ActiveChanged.InvokeAsync(false);
        }
    }
}
