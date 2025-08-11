using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An editable form wraps inline editing functionality in a `&lt;form&gt;` element, providing
/// submit and cancel semantics with keyboard support. It is useful for editing records in place,
/// such as updating a user profile, renaming an item, or modifying settings without navigating to a
/// separate page.
/// </summary>
/// <example>
/// <code>
/// &lt;EditableForm label="Edit profile" @bind-Editing onsubmit=@save&gt;
///   &lt;input name="name" value=@name /&gt;
///   &lt;button type="submit"&gt;Save&lt;/button&gt;
/// &lt;/EditableForm&gt;
/// </code>
/// </example>
public partial class EditableForm : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public string Label { get; set; } = "";
    [Parameter] public bool Editing { get; set; }
    [Parameter] public EventCallback<bool> EditingChanged { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    [Parameter] public EventCallback OnSubmit { get; set; }

    private Task HandleKeyDown(KeyboardEventArgs e) => Task.CompletedTask;

    private async Task HandleSubmit()
    {
        if (OnSubmit.HasDelegate)
            await OnSubmit.InvokeAsync();
    }

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "editable-form" : $"editable-form {CssClass}";
}
