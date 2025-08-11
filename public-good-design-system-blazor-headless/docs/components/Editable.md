# Editable

An editable component allows inline text editing. It displays a value as plain text that can be clicked or activated via keyboard to enter edit mode, where it becomes an input field. Pressing Enter confirms the edit, and pressing Escape cancels it, reverting to the original value.

This headless component toggles between a display state (`<span role="button">`) and an edit state (`<input type="text">`). It maintains a draft value during editing so that cancellation restores the original text. Both the `value` and `editing` state support two-way binding.

## Implementation Notes

- Display mode renders a `<span>` with `role="button"` and `tabindex="0"` for keyboard activation
- Edit mode renders an `<input type="text">` bound to an internal draft value
- Uses `@bind-` for both `value` and `editing` props
- Uses `private field` for the internal draft value during editing
- Enter key in edit mode calls `confirm()` which copies draft to value
- Escape key in edit mode calls `cancel()` which restores draft from value
- Display mode responds to click, Enter, and Space for activation
- When `disabled` is true, the span gets `tabindex="-1"` and `aria-disabled`
- Accepts `AdditionalAttributes` for forwarding additional attributes

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Editing` | `bool` | `—` | The editing value |
| `EditingChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Editing |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<Editable label="Name" @bind-Value />
```


```razor
<Editable label="Title" @bind-Value @bind-Editing />
```


## Keyboard Interactions

In display mode:
- Enter: Activate edit mode
- Space: Activate edit mode

In edit mode:
- Enter: Confirm the edit and return to display mode
- Escape: Cancel the edit and return to display mode

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name in both display and edit modes
- `role="button"` -- on the display span, indicates it is an activatable element
- `aria-disabled={disabled}` -- on the display span when disabled, communicates the disabled state
- `tabindex="0"` / `tabindex="-1"` -- controls focusability based on disabled state

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
