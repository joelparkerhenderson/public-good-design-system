# United Kingdom National Health Service Number Input

A United Kingdom National Health Service (NHS) number input is a specialized
form field for entering a 10-digit NHS patient identifier. The NHS number is
assigned to every patient registered with the National Health Service in
England, Wales, and the Isle of Man, and is used to uniquely identify
individuals across the health system.

The standard display format is "XXX XXX XXXX" (three groups of digits separated
by spaces). This input component enforces that pattern, uses a numeric keyboard
hint for mobile devices, and disables autocomplete to protect sensitive health
information. The component supports required and disabled states, and provides
accessible labeling for screen readers.

## Implementation Notes

- Renders as `<input type="text">` with pattern validation for NHS number format
- Pattern: `[0-9]{3} [0-9]{3} [0-9]{4}` (XXX XXX XXXX)
- `inputmode="numeric"` for numeric keyboard on mobile
- `autocomplete="off"` to protect sensitive health identifiers
- Supports two-way binding
- Pattern is defined as a constant for validation

## Props

- `label`: string (required) -- accessible label via aria-label
- `value`: string (default: "") -- bindable input value
- `required`: boolean (default: false) -- form validation
- `disabled`: boolean (default: false) -- disabled state
- `...restProps`: Any additional HTML attributes spread onto the `<input>`

## Usage

```html
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" />
```

With two-way binding:

```html
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" value={nhsNumber} />
```

Required field in a form:

```html
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" required />
```

Disabled state:

```html
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" disabled />
```

## Keyboard Interactions

- Standard text input keyboard behavior
- Users type digits and spaces in the format XXX XXX XXXX

## ARIA

- `aria-label` provides accessible name from label prop
- `required` and `disabled` states conveyed to assistive technology
- `inputmode="numeric"` hints mobile assistive technology to present a numeric keyboard

## When to Use

- Use UnitedKingdomNationalHealthServiceNumberInput when a form requires entry of a UK NHS patient identifier in the standard XXX XXX XXXX format.
- Use in healthcare applications, patient registration forms, or any system that processes NHS numbers.
- Avoid using a generic text input for NHS numbers; this component provides pattern validation and numeric keyboard hints.
- Consider UnitedKingdomNationalHealthServiceNumberView for displaying an existing NHS number in a read-only context.

## Headless

This headless component provides an `<input type="text">` with NHS number pattern validation, `inputmode="numeric"`, `autocomplete="off"`, `aria-label`, and support for `required`/`disabled` states. The consumer provides all visual styling, surrounding labels, hints, and error messages.

## Advice

- **Designers**: Display a format hint (e.g., "XXX XXX XXXX") near the input to help users enter the number correctly. Use error messaging for invalid formats.
- **Developers**: The component enforces the pattern `[0-9]{3} [0-9]{3} [0-9]{4}` on form submission. Consider adding real-time formatting or a checksum validation for the NHS number's modulus 11 algorithm.

## Composition

UnitedKingdomNationalHealthServiceNumberInput is the editable input counterpart to UnitedKingdomNationalHealthServiceNumberView, following the Input/View pattern. Use the Input for data entry and the View for read-only display.

## References

- NHS Number format: https://www.nhs.uk/nhs-services/online-services/find-nhs-number/
