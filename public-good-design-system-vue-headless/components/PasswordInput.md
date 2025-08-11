# PasswordInput

A password input provides a single-line text field with obscured text entry using the native HTML `<input type="password">` element. It includes browser password manager integration via the autocomplete attribute and accessible labeling via aria-label.

Unlike PasswordInputOrTextInputDiv, which wraps the input in a `<div>` with a show/hide toggle button, PasswordInput renders only the bare `<input>` element. This makes it suitable when the consumer wants full control over the surrounding layout and any visibility toggle behavior.

## Implementation Notes

- Renders a native `<input type="password">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Uses `defineModel()` for the value prop, enabling `v-model` in the parent
- Default `autocomplete="current-password"` for browser password manager support
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads rest props for consumer customization (e.g., `placeholder`, `maxlength`, `pattern`)

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: `""`, bindable) -- current password value, supports two-way binding via v-model
- `autocomplete`: string (default: `"current-password"`) -- autocomplete hint for browsers
- `required`: boolean (default: `false`) -- whether the field is required
- `disabled`: boolean (default: `false`) -- whether the field is disabled
- `...restProps`: any additional HTML attributes spread onto the input

## Usage

```vue
<PasswordInput label="Password" v-model="password" />
```

```vue
<PasswordInput label="New password" v-model="newPassword" autocomplete="new-password" required />
```

```vue
<PasswordInput label="Password" v-model="password" disabled />
```

## Keyboard Interactions

None beyond native input behavior -- standard text editing keys (typing, backspace, selection, clipboard shortcuts) are handled by the browser.

## ARIA

- `aria-label={label}` -- provides an accessible name for the input since no visible `<label>` element is included

## References

- MDN input type="password": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/password
