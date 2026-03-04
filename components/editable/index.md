# Editable

An editable component allows inline text editing. It displays a value as plain text that can be clicked or activated via keyboard to enter edit mode, where it becomes an input field. Pressing Enter confirms the edit, and pressing Escape cancels it, reverting to the original value.

This headless component toggles between a display state (`<span role="button">`) and an edit state (`<input type="text">`). It maintains a draft value during editing so that cancellation restores the original text. Both the `value` and `editing` state support two-way binding.

## Implementation Notes

- Display mode renders a `<span>` with `role="button"` and `tabindex="0"` for keyboard activation
- Edit mode renders an `<input type="text">` bound to an internal draft value
- Supports two-way binding for both `value` and `editing` props
- Uses reactive state for the internal draft value during editing
- Enter key in edit mode calls `confirm()` which copies draft to value
- Escape key in edit mode calls `cancel()` which restores draft from value
- Display mode responds to click, Enter, and Space for activation
- When `disabled` is true, the span gets `tabindex="-1"` and `aria-disabled`
- Accepts `...restProps` for forwarding additional attributes

## Props

- `value`: string (default: "") -- current text value; bindable
- `label`: string (required) -- accessible name for the editable control, applied via `aria-label`
- `editing`: boolean (default: false) -- whether the component is in edit mode; bindable
- `disabled`: boolean (default: false) -- whether editing is disabled

## Usage

```html
<Editable label="Name" value={value} />
```

```html
<Editable label="Title" value={value} editing={editing} />
```

## Keyboard Interactions

In display mode:
- Enter: Activate edit mode
- Space: Activate edit mode

In edit mode:
- Enter: Confirm the edit and return to display mode
- Escape: Cancel the edit and return to display mode

## ARIA

- `aria-label={label}` -- provides an accessible name in both display and edit modes
- `role="button"` -- on the display span, indicates it is an activatable element
- `aria-disabled={disabled}` -- on the display span when disabled, communicates the disabled state
- `tabindex="0"` / `tabindex="-1"` -- controls focusability based on disabled state

## When to Use

- Use for inline text editing where users can click or activate a value to edit it in place, such as renaming items, updating profile fields, or quick edits in tables.
- Use when navigating to a separate edit page would be disruptive to the workflow.
- Avoid for multi-field forms; use EditableForm or a standard Form instead.
- Consider TextInput instead when the field is always in edit mode and does not toggle.

## Headless

This headless component provides a display mode (`<span>` with `role="button"`) and edit mode (`<input type="text">`) with full keyboard support (Enter to confirm, Escape to cancel), draft value management, two-way binding on both `value` and `editing`, and disabled state handling. The consumer provides all visual styling for both display and edit modes.

## Advice

- **Designers**: Make the display text visually distinct from static text (e.g., with an underline or hover effect) so users know it is editable. Provide clear visual feedback when entering and exiting edit mode.
- **Developers**: Use the `editing` bind to coordinate with other components or show save/cancel buttons. The component manages a draft value internally, so cancellation safely reverts changes.

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
