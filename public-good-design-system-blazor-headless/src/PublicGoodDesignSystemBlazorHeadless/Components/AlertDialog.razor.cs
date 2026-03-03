using Microsoft.AspNetCore.Components;

namespace PublicGoodDesignSystemBlazorHeadless.Components;

/// <summary>
/// An alert dialog is a modal dialog that interrupts the user's workflow to communicate critical
/// information and require a response. Unlike regular dialogs, alert dialogs demand immediate
/// attention -- they are used for important warnings, confirmations of destructive actions, or
/// error conditions that must be acknowledged before the user can continue.
/// </summary>
/// <example>
/// <code>
/// &lt;button @onclick="HandleClick"&gt;Delete item&lt;/button&gt;
/// 
/// &lt;AlertDialog
///   @bind-Open="showDialog"
///   title="Confirm Deletion"
///   description="Are you sure you want to delete this item? This action cannot be undone."
/// &gt;
///   &lt;button @onclick="handleConfirm"&gt;Yes, delete&lt;/button&gt;
///   &lt;button @onclick="handleCancel"&gt;Cancel&lt;/button&gt;
/// &lt;/AlertDialog&gt;
/// </code>
/// </example>
public partial class AlertDialog : ComponentBase
{
    [Parameter] public string? CssClass { get; set; }
    [Parameter] public bool Open { get; set; }
    [Parameter] public EventCallback<bool> OpenChanged { get; set; }
    [Parameter] public string Title { get; set; } = "";
    [Parameter] public string? Description { get; set; }
    [Parameter] public RenderFragment ChildContent { get; set; }
    [Parameter(CaptureUnmatchedValues = true)]
    public Dictionary<string, object>? AdditionalAttributes { get; set; }


    private string TitleId => "alert-dialog-title";

    private string CssClasses => string.IsNullOrEmpty(CssClass) ? "alert-dialog" : $"alert-dialog {CssClass}";
}
