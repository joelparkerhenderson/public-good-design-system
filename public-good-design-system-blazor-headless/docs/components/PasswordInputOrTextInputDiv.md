# PasswordInputOrTextInputDiv

PasswordInputOrTextInputDiv is a headless component that wraps a native `<input type="password">` element with accessible labelling and an optional toggle button to show or hide the password text. The input automatically includes `autocomplete="current-password"` for proper browser password manager integration.

This component is useful for login forms, registration forms, account settings, or any interface requiring secure password entry. The show/hide toggle improves usability by letting users verify their input, while the `aria-pressed` attribute on the toggle button communicates the visibility state to assistive technologies.

## Implementation Notes

- Renders a wrapper `<div>` containing the password input and an optional toggle button
- The input type dynamically switches between `"password"` and `"text"` based on the `visible` state
- Uses `$state(false)` to track password visibility internally
- Uses `$bindable("")` for the `value` prop, enabling two-way binding
- The toggle button uses `aria-pressed` to indicate the current visibility state
- Includes `autocomplete="current-password"` on the input for browser password manager support
- Supports `required` and `disabled` boolean states on the input
- Spreads `AdditionalAttributes` onto the wrapper `<div>` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `ShowToggle` | `bool` | `true` | The show toggle value |
| `ToggleLabel` | `string?` | `Show password` | The toggle label value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<PasswordInputOrTextInputDiv label="Password" @bind-Value />
```


## Keyboard Interactions

- Enter/Space on the toggle button: Toggles password visibility between masked and plain text

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the password input
- `aria-label={toggleLabel}` -- provides an accessible name for the toggle button
- `aria-pressed={visible}` -- indicates whether the password is currently visible (on the toggle button)

## References

- HTML password input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/password
- WAI-ARIA Button Pattern (toggle): https://www.w3.org/WAI/ARIA/apg/patterns/button/
