# Alert Dialog

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
- two-way binding on the `open` prop for dialog visibility
- Conditionally rendered with conditional rendering to remove from DOM when closed
- `aria-modal="true"` signals modal behavior to assistive technologies
- Title rendered in a `<p><strong>` element, referenced by `aria-labelledby`
- Description rendered in a `<p>` element, referenced by `aria-describedby` when present
- Consumers are responsible for focus trapping and Escape key handling

## Props

- `open`: boolean (default: false, bindable) -- whether the dialog is visible
- `title`: string (required) -- dialog heading, referenced by aria-labelledby
- `description`: string (optional) -- dialog message, referenced by aria-describedby
- `children`: slot -- action buttons and additional content
- `...restProps`: Any additional HTML attributes

## Usage

Basic confirmation dialog:

```html
<button onclick={() => showDialog = true}>Delete item</button>

<AlertDialog
  open={showDialog}
  title="Confirm Deletion"
  description="Are you sure you want to delete this item? This action cannot be undone."
>
  <button onclick={handleConfirm}>Yes, delete</button>
  <button onclick={handleCancel}>Cancel</button>
</AlertDialog>
```

Simple acknowledgment dialog without description:

```html
<AlertDialog open={showAlert} title="Session Expired">
  <button onclick={() => showAlert = false}>OK</button>
</AlertDialog>
```

## Keyboard Interactions

- Escape: Closes the dialog (consumer must implement via onkeydown)
- Tab: Focus should be trapped within the dialog (consumer responsibility)

## ARIA

- `role="alertdialog"`
- `aria-modal="true"`
- `aria-labelledby` references the title element
- `aria-describedby` references the description element (when present)

## When to Use

- Use for critical confirmations that require user acknowledgment, such as confirming a destructive action ("Delete this item?"), warning about unsaved changes, or displaying errors that block further interaction.
- Use when the dialog content demands immediate attention and must be addressed before the user can continue.
- Avoid for non-urgent informational messages -- use Alert or Dialog instead.
- Consider Dialog instead when the content is interactive but does not require urgent acknowledgment.

## Headless

This component provides `role="alertdialog"`, `aria-modal`, `aria-labelledby`, and `aria-describedby` attributes on a native `<dialog>` element with zero visual styling. The consumer is responsible for all CSS including backdrop overlay, dialog positioning, sizing, padding, button styles, and focus trap implementation.


## Styles

The consumer provides all CSS styling. The component renders with a `.alert-dialog` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<dialog>` element with class `alert-dialog`
- Verify role="alertdialog"
- Verify aria-labelledby` references the title element
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Ensure the dialog has a clear title, a concise description of the action, and distinguishable confirm/cancel buttons with appropriate visual weight (e.g., a destructive action button should appear more prominent and cautionary).
- **Developers**: The consumer must implement focus trapping and Escape key handling. Set initial focus on the least destructive action button (e.g., "Cancel") to prevent accidental confirmations.

## References

- WAI-ARIA alertdialog role: https://www.w3.org/TR/wai-aria-1.2/#alertdialog
- WAI-ARIA Alert and Message Dialogs Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alertdialog/
