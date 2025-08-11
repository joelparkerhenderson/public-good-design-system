using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A tour guide list item is a single step within a TourList guided tour. Each step represents one
/// screen or instruction in the tour sequence. The step conditionally shows or hides based on the
/// `current` prop, using the `hidden` attribute and `aria-hidden` for proper accessibility. Step
/// progress information is communicated to screen readers through the accessible label.
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
public partial class TourListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Current { get; set; }
    [Parameter] public string StepNumber { get; set; } = "";
    [Parameter] public string TotalSteps { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string FullLabel => $"Step {StepNumber} of {TotalSteps}: {Label}";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "tour-list-item" : $"tour-list-item {CssClass}";
}
