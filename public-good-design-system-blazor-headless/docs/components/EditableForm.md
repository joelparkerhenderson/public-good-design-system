# EditableForm

An editable form wraps inline editing functionality in a `<form>` element, providing submit and cancel semantics with keyboard support. It is useful for editing records in place, such as updating a user profile, renaming an item, or modifying settings without navigating to a separate page.

The form is only rendered when the `editing` prop is true. Submitting the form automatically exits edit mode and calls the `onsubmit` callback. Pressing Escape cancels editing and calls the `oncancel` callback. This pattern gives consumers full control over the edit lifecycle.

## Implementation Notes

- Conditionally renders a `<form>` only when `editing` is true
- Uses `@bind-` on the `editing` prop for two-way state binding
- Calls `event.preventDefault()` on submit to allow consumer-controlled save logic
- Sets `editing` to `false` on both submit and Escape key press
- Sets `tabindex="-1"` on the form to allow programmatic focus management
- Escape key handler calls the `oncancel` callback

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Editing` | `bool` | `—` | The editing value |
| `EditingChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Editing |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |
| `OnSubmit` | `EventCallback` | `—` | The on submit value |

## Usage


```razor
<EditableForm label="Edit profile" @bind-Editing onsubmit=@save>
  <input name="name" value=@name />
  <button type="submit">Save</button>
</EditableForm>
```


```razor
<EditableForm label="Rename item" @bind-Editing onsubmit=@rename oncancel=@revert>
  <input name="title" value=@title />
  <button type="submit">OK</button>
  <button type="button" @onclick="HandleClick">Cancel</button>
</EditableForm>
```


## Keyboard Interactions

- Enter: submits the form (native form behavior), exits edit mode, calls `onsubmit`
- Escape: cancels editing, exits edit mode, calls `oncancel`

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the form

## References

- WAI-ARIA Form Role: https://www.w3.org/WAI/ARIA/apd/roles/form/
