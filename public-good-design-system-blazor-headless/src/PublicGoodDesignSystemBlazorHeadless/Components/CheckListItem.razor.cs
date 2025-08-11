using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// A single item within a CheckList. Renders as an `&lt;li&gt;` containing a checkbox
/// `&lt;input&gt;` and a `&lt;label&gt;` for the item text.
/// </summary>
/// <example>
/// <code>
/// &lt;CheckList label="Onboarding tasks"&gt;
///   &lt;CheckListItem checked&gt;Create account&lt;/CheckListItem&gt;
///   &lt;CheckListItem&gt;Set up profile&lt;/CheckListItem&gt;
///   &lt;CheckListItem disabled&gt;Admin only&lt;/CheckListItem&gt;
/// &lt;/CheckList&gt;
/// </code>
/// </example>
public partial class CheckListItem : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Checked { get; set; }
    [Parameter] public bool Disabled { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "check-list-item" : $"check-list-item {CssClass}";
}
