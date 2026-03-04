# Text Input

A text input provides a single-line text field for entering short text values such as names, titles, or other brief textual data. It wraps the native HTML `<input type="text">` element with accessible labelling and two-way data binding.

This component is suitable for any form field requiring free-text entry. It supports required and disabled states and uses `aria-label` to ensure screen readers announce the field purpose. The bindable `value` prop enables reactive two-way data flow with the parent component.

## Implementation Notes

- Renders a native `<input type="text">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Supports two-way binding for the `value` prop, enabling two-way `value` binding in the parent
- Supports two-way binding on the `value` prop
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads `restProps` for consumer customization (e.g., `placeholder`, `maxlength`, `pattern`)

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: `""`, bindable) -- current text value, supports two-way binding
- `required`: boolean (default: `false`) -- whether the field is required
- `disabled`: boolean (default: `false`) -- whether the field is disabled
- `...restProps`: any additional HTML attributes spread onto the input

## Usage

```html
<TextInput label="Full name" value={value} />
```

```html
<TextInput label="Email" value={email} required={true} />
```

```html
<TextInput label="Notes" value={notes} disabled={true} />
```

## Keyboard Interactions

None beyond native input behavior -- standard text editing keys (typing, backspace, selection, clipboard shortcuts) are handled by the browser.

## ARIA

- `aria-label={label}` -- provides an accessible name for the input since no visible `<label>` element is included

## When to Use

- Use for short, single-line text entry such as names, titles, search terms, or other brief textual data in forms.
- Use when the expected input fits comfortably on one line.
- Avoid for multi-line text entry; use Textarea instead.
- Consider a specialized input (EmailInput, TelInput, UrlInput, SearchInput) when the data type has a specific semantic meaning.

## Headless

This headless component renders a native `<input type="text">` with `aria-label` and two-way value binding. It provides standard text input semantics, required/disabled states, and rest prop forwarding for attributes like `placeholder`, `maxlength`, and `pattern`. The consumer provides all visual styling.

## Advice

- **Designers**: Size the input width to match the expected content length (e.g., wider for full names, narrower for short codes). Use placeholder text sparingly and never as a substitute for labels.
- **Developers**: Use `restProps` to pass `placeholder`, `maxlength`, `pattern`, and other native attributes. Wrap the input with a Field and Label component for a complete accessible form field.

## References

- MDN input type="text": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/text
