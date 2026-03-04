# Tel Input

A telephone input component that provides a telephone number input field using the native HTML `<input type="tel">` element. It includes accessible labeling via `aria-label` and browser autofill support via `autocomplete="tel"`, making it suitable for contact forms, registration flows, and profile editors.

The component supports two-way data binding through a bindable `value` prop, allowing parent components to read and write the telephone number. It also supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Renders as a single `<input type="tel">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can wrap with their own `<label>`)
- `autocomplete="tel"` enables browser and password manager autofill for phone numbers
- Bindable `value` prop uses two-way binding for two-way data binding
- Supports `required` and `disabled` HTML attributes natively
- Spreads `...restProps` onto the `<input>` for additional attributes like `placeholder`, `pattern`, `maxlength`, etc.

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: string (default: `""`) -- bindable telephone number value
- `required`: boolean (default: `false`) -- whether the field is required for form submission
- `disabled`: boolean (default: `false`) -- whether the field is disabled
- `...restProps`: any -- additional HTML attributes spread onto the `<input>` element

## Usage

```html
<TelInput label="Phone number" value={value} />
```

```html
<TelInput label="Mobile" value={value} required />
```

## Keyboard Interactions

- Native `<input type="tel">` keyboard behavior applies (Tab to focus, type to enter digits)

## ARIA

- `aria-label` -- provides the accessible name for the input, set from the `label` prop
- `autocomplete="tel"` -- signals browsers to offer telephone number autofill

## When to Use

- Use in forms where users need to enter a telephone number, such as contact forms, registration flows, or profile editors.
- Use when browser autofill for phone numbers (`autocomplete="tel"`) is beneficial.
- Avoid when you need formatted phone display; use TelLink for read-only phone number presentation.
- Consider pairing with a country code selector for international phone number entry.

## Headless

This headless component renders a native `<input type="tel">` with `aria-label`, `autocomplete="tel"`, and two-way value binding. It provides telephone input semantics with browser autofill support. The consumer provides all visual styling including borders, padding, placeholder text, and validation feedback.

## Advice

- **Designers**: Show an example format as placeholder text (e.g., "+1-555-0100") to guide user input. Place the phone input near related contact fields.
- **Developers**: Use the `pattern` attribute via `restProps` for client-side validation of phone number formats. Pair TelInput with TelLink to create an input/display pair for phone numbers.

## Composition

TelInput and TelLink follow the Input/Link pattern. TelInput provides the editable telephone input for forms, while TelLink provides the read-only clickable `tel:` link for display. Use them together for edit and view modes of phone number data.

## References

- HTML tel input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/tel
