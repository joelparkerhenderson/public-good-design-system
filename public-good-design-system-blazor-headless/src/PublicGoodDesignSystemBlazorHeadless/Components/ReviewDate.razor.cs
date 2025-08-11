using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A review date component displays a date associated with a review, audit, or scheduled check-in.
/// It renders as a semantic HTML `&lt;time&gt;` element with a machine-readable `datetime`
/// attribute in ISO 8601 format and human-readable display text provided through a children
/// snippet. This separation allows browsers and assistive technologies to parse the date for
/// accurate interpretation while displaying a user-friendly formatted date.
/// </summary>
/// <example>
/// <code>
/// &lt;ReviewDate label="Next review" datetime="2025-06-15"&gt;June 15, 2025&lt;/ReviewDate&gt;
/// </code>
/// </example>
public partial class ReviewDate : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public string Datetime { get; set; } = "";
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "review-date" : $"review-date {CssClass}";
}
