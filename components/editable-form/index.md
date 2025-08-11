# Editable Form

An editable form wraps inline editing functionality in a `<form>` element, providing submit and cancel semantics with keyboard support. It is useful for editing records in place, such as updating a user profile, renaming an item, or modifying settings without navigating to a separate page.

The form is only rendered when the `editing` prop is true. Submitting the form automatically exits edit mode and calls the `onsubmit` callback. Pressing Escape cancels editing and calls the `oncancel` callback. This pattern gives consumers full control over the edit lifecycle.

## Implementation Notes

- Conditionally renders a `<form>` only when `editing` is true
- Supports two-way binding on the `editing` prop for two-way state binding
- Calls `event.preventDefault()` on submit to allow consumer-controlled save logic
- Sets `editing` to `false` on both submit and Escape key press
- Sets `tabindex="-1"` on the form to allow programmatic focus management
- Escape key handler calls the `oncancel` callback

## Props

- `label`: string (required) -- accessible name for the form, applied as `aria-label`
- `editing`: boolean (default: false) -- whether the form is in edit mode, two-way bindable via `editing`
- `onsubmit`: (event: SubmitEvent) => void (default: undefined) -- callback when the form is submitted
- `oncancel`: () => void (default: undefined) -- callback when editing is cancelled
- `children`: slot (required) -- form content (inputs, buttons, etc.)

## Usage

```html
<EditableForm label="Edit profile" editing={editing} onsubmit={save}>
  <input name="name" value={name} />
  <button type="submit">Save</button>
</EditableForm>
```

```html
<EditableForm label="Rename item" editing={editing} onsubmit={rename} oncancel={revert}>
  <input name="title" value={title} />
  <button type="submit">OK</button>
  <button type="button" onclick={() => editing = false}>Cancel</button>
</EditableForm>
```

## Keyboard Interactions

- Enter: submits the form (native form behavior), exits edit mode, calls `onsubmit`
- Escape: cancels editing, exits edit mode, calls `oncancel`

## ARIA

- `aria-label={label}` -- provides an accessible name for the form

## When to Use

- Use when inline editing requires form submission semantics, such as updating a record, renaming an item, or modifying settings in place.
- Use when you need submit and cancel lifecycle callbacks with proper `<form>` behavior.
- Avoid for simple single-field inline edits; use Editable instead.
- Consider a full-page Form when the editing involves many fields or complex validation.

## Headless

This headless component provides a conditionally rendered `<form>` with accessible labeling via `aria-label`, submit handling with `preventDefault`, Escape key cancellation, and two-way binding on the `editing` prop. The consumer provides all visual styling, form controls, and action buttons.


## Styles

The consumer provides all CSS styling. The component renders with a `.editable-form` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<form>` element with class `editable-form`
- Verify aria-label={label}` -- provides an accessible name for the form
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Provide clear save and cancel affordances within the form. Visually differentiate the editing state from the read-only state so users know when they are in edit mode.
- **Developers**: Use the `onsubmit` callback for save logic and `oncancel` for revert logic. The form automatically exits edit mode on both submit and Escape.

## Composition

EditableForm composes with Editable and form input components. EditableForm provides the `<form>` wrapper with submit/cancel lifecycle, while Editable can be used inside for individual inline-editable fields. Use Field, TextInput, and other input components as form content.

## References

- WAI-ARIA Form Role: https://www.w3.org/WAI/ARIA/apd/roles/form/
