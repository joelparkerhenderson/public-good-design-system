# AlertDialog

An alert dialog is a modal dialog that interrupts the user's workflow to
communicate critical information and require a response. Unlike regular dialogs,
alert dialogs demand immediate attention -- they are used for important warnings,
confirmations of destructive actions, or error conditions that must be
acknowledged before the user can continue.

Alert dialogs are distinguished from standard dialogs by the `alertdialog` ARIA
role, which signals to assistive technologies that the content requires the
user's immediate attention. Common uses include confirming irreversible actions
(e.g., "Delete this item?"), warning about unsaved changes, or displaying
critical error messages that require acknowledgment.

## Implementation Notes

- Uses native HTML `<dialog>` element with the `open` attribute for visibility
- `role="alertdialog"` distinguishes from regular dialogs -- indicates critical content requiring acknowledgment
- `@bind-` open prop for two-way binding of dialog visibility
- Conditionally rendered with `{#if open}` to remove from DOM when closed
- `aria-modal="true"` signals modal behavior to assistive technologies
- Title rendered in a `<p><strong>` element, referenced by `aria-labelledby`
- Description rendered in a `<p>` element, referenced by `aria-describedby` when present
- Consumers are responsible for focus trapping and Escape key handling

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `Title` | `string` | `—` | The title value |
| `Description` | `string?` | `—` | The description value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage

Basic confirmation dialog:

```razor
@code {

  private bool showDialog = false;;

  private void handleConfirm() {
    // perform action
    showDialog = false;
  }

  private void handleCancel() {
    showDialog = false;
  }
}

<button @onclick="HandleClick">Delete item</button>

<AlertDialog
  @bind-Open="showDialog"
  title="Confirm Deletion"
  description="Are you sure you want to delete this item? This action cannot be undone."
>
  <button @onclick="handleConfirm">Yes, delete</button>
  <button @onclick="handleCancel">Cancel</button>
</AlertDialog>
```

Simple acknowledgment dialog without description:

```razor
@code {

  private bool showAlert = false;;
}

<AlertDialog @bind-Open="showAlert" title="Session Expired">
  <button @onclick="HandleClick">OK</button>
</AlertDialog>
```


## Keyboard Interactions

- Escape: Closes the dialog (consumer must implement via onkeydown)
- Tab: Focus should be trapped within the dialog (consumer responsibility)

## ARIA Attributes

- `role="alertdialog"`
- `aria-modal="true"`
- `aria-labelledby` references the title element
- `aria-describedby` references the description element (when present)

## References

- WAI-ARIA alertdialog role: https://www.w3.org/TR/wai-aria-1.2/#alertdialog
- WAI-ARIA Alert and Message Dialogs Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alertdialog/
