# Form

A form component wraps a native HTML `<form>` element with accessible labeling, automatic submit default prevention, and reset support. It simplifies form handling by intercepting the submit event and calling `preventDefault()` before passing it to the consumer's callback, which is the most common pattern in single-page applications.

## Implementation Notes

- Renders a native `<form>` element with `aria-label` for accessible naming
- Automatically calls `event.preventDefault()` on submit before invoking the `onsubmit` callback
- Passes the raw `onreset` callback directly to the form (no default prevention)
- Accepts a `ChildContent` RenderFragment for form content (inputs, buttons, etc.)
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `OnSubmit` | `EventCallback` | `—` | The on submit value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Form label="Login" onsubmit=@handleLogin>
  <input name="email" />
  <button type="submit">Sign in</button>
</Form>
```


## Keyboard Interactions

None beyond native form behavior -- Enter key submits the form when a text input is focused (browser default).

## ARIA Attributes

- `aria-label="..."` -- provides an accessible name for the form, helping screen readers identify its purpose

## References

- MDN `<form>`: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/form
- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
