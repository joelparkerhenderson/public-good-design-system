# Postal Code Input

A postal code input provides a text field specifically designed for entering postal or ZIP codes. It includes `autocomplete="postal-code"` to enable browsers to auto-fill the value from stored address data, streamlining address form completion.

This component is useful in address forms, checkout flows, shipping calculators, and any interface that requires postal code entry. It pairs with PostalCodeView for displaying the entered value in read-only contexts. The bindable value prop supports two-way data binding with the parent component.

## Implementation Notes

- Renders a native `<input type="text">` element (not `type="number"`, since postal codes may contain letters or dashes)
- Uses `autocomplete="postal-code"` to hint browser autofill for postal/ZIP code fields
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Supports two-way binding for the `value` prop, enabling two-way `value` binding in the parent
- Supports two-way binding on the `value` prop
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads `restProps` for consumer customization (e.g., `placeholder`, `pattern`, `maxlength`)

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: `""`, bindable) -- current postal code value, supports two-way binding
- `required`: boolean (default: `false`) -- whether the field is required
- `disabled`: boolean (default: `false`) -- whether the field is disabled
- `...restProps`: any additional HTML attributes spread onto the input

## Usage

```html
<PostalCodeInput label="Postal code" value={value} />
```

```html
<PostalCodeInput label="ZIP code" value={zipCode} required={true} />
```

```html
<PostalCodeInput label="Postcode" value={postcode} placeholder="SW1A 1AA" />
```

## Keyboard Interactions

None beyond native input behavior -- standard text editing keys (typing, backspace, selection, clipboard shortcuts) are handled by the browser.

## ARIA

- `aria-label={label}` -- provides an accessible name for the input since no visible `<label>` element is included

## When to Use

- Use PostalCodeInput in address forms, checkout flows, and shipping calculators where users need to enter a postal or ZIP code.
- Use PostalCodeInput when you want browser autofill support via `autocomplete="postal-code"`.
- Avoid using PostalCodeInput for general text or numeric fields; use TextInput or NumberInput instead.

## Headless

The PostalCodeInput headless component provides a native `<input type="text">` with `autocomplete="postal-code"`, `aria-label` for accessible naming, and two-way value binding. The consumer provides all visual styling, validation patterns, placeholder text, and layout.

## Advice

- **Designers**: Size the input field to match the expected postal code format for your target locale, and include a placeholder showing the expected format (e.g., "SW1A 1AA" or "90210").
- **Developers**: Use the `pattern` attribute via `restProps` to validate locale-specific postal code formats, and pair with PostalCodeView for read-only display contexts.

## Composition

PostalCodeInput is the editable counterpart of PostalCodeView. Use PostalCodeInput for data entry and PostalCodeView for read-only display of the same postal code value.

## References

- HTML autocomplete attribute: https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete
- MDN input type="text": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/text
