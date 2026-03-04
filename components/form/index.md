# Form

A form component wraps a native HTML `<form>` element with accessible labeling, automatic submit default prevention, and reset support. It simplifies form handling by intercepting the submit event and calling `preventDefault()` before passing it to the consumer's callback, which is the most common pattern in single-page applications.

## Implementation Notes

- Renders a native `<form>` element with `aria-label` for accessible naming
- Automatically calls `event.preventDefault()` on submit before invoking the `onsubmit` callback
- Passes the raw `onreset` callback directly to the form (no default prevention)
- Accepts a `children` slot for form content (inputs, buttons, etc.)
- Spreads `restProps` for consumer customization

## Props

- `label`: string (required) -- accessible name for the form via `aria-label`
- `onsubmit`: function (default: `undefined`) -- callback receiving `SubmitEvent` (default already prevented)
- `onreset`: function (default: `undefined`) -- callback receiving `Event` on form reset
- `children`: slot (required) -- form content to render inside
- `...restProps`: unknown -- additional attributes spread onto the `<form>`

## Usage

```html
<Form label="Login" onsubmit={handleLogin}>
  <input name="email" />
  <button type="submit">Sign in</button>
</Form>
```

## Keyboard Interactions

None beyond native form behavior -- Enter key submits the form when a text input is focused (browser default).

## ARIA

- `aria-label="..."` -- provides an accessible name for the form, helping screen readers identify its purpose

## When to Use

- Use to wrap any collection of form inputs that are submitted together as a unit.
- Use when you need automatic `preventDefault()` on submit, which is standard in single-page applications.
- Avoid wrapping unrelated input groups in a single Form; use separate Form components for distinct submission actions.

## Headless

This headless component provides a native `<form>` element with `aria-label`, automatic submit default prevention, and reset support. The consumer provides all visual styling including layout, spacing, and button placement.

## Advice

- **Designers**: Group related fields visually using spacing or Fieldset components. Place the primary submit button in a predictable location.
- **Developers**: Use the Form composition pattern: Form wraps Field components, which in turn wrap input components. Pair with ErrorSummary for validation feedback.

## Composition

Form uses the Form composition pattern: Form contains Field components, which wrap input components (TextInput, EmailInput, Select, etc.). Add ErrorSummary for validation errors and Button for submission actions.

## References

- MDN `<form>`: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/form
- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
