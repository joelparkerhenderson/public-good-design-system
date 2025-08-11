# EmailInput

An email input wraps a native `<input type="email">` with accessible labeling. A simpler variant of EmailAddressInput for basic email collection, it omits placeholder and autocomplete support in favor of a minimal API. Use EmailInput when you need a straightforward email field with required and disabled state support.

## Implementation Notes

- Renders a native `<input type="email">` element for browser-native email validation
- Uses `bind:value` with `$bindable()` for two-way binding of the email string
- Provides `aria-label` for screen reader accessibility
- Supports `required` and `disabled` for standard form behavior
- Spreads `restProps` for consumer customization
- Unlike EmailAddressInput, does not set `autocomplete` or support `placeholder`

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: `""`) -- current email value, bindable via `bind:value`
- `required`: boolean (default: `false`) -- whether the field is required
- `disabled`: boolean (default: `false`) -- whether the field is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>`

## Usage

```svelte
<EmailInput label="Your email" bind:value />
```

## Keyboard Interactions

None -- keyboard behavior is provided by the browser-native email input.

## ARIA

- `aria-label="..."` -- provides an accessible name for the email input since it has no visible `<label>` element

## References

- MDN `<input type="email">`: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/email
