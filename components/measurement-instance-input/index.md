# Measurement Instance Input

A measurement instance input provides a text field for entering a specific measurement value, such as "72 kg", "98.6 F", or "120/80 mmHg". A measurement instance represents an individual recorded measurement with both its numeric value and unit.

The component uses `aria-label` for accessible labeling in a headless context, and the `value` prop is two-way bindable for reactive form integration. It supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Uses `<input type="text">` with `aria-label` for accessible naming
- A measurement instance is a specific measured value (e.g., "72 kg", "98.6 F")
- Bindable `value` prop for two-way data binding via two-way binding
- Supports `required` and `disabled` HTML attributes
- Spreads `...restProps` on the root `<input>` element
- All text content comes through props for internationalization

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: "", bindable) -- bindable measurement instance value
- `required`: boolean (default: false) -- whether the field is required
- `disabled`: boolean (default: false) -- whether the field is disabled
- `...restProps`: Any additional HTML attributes passed to the `<input>` element

## Usage

```html
<MeasurementInstanceInput label="Weight" value={value} />
<MeasurementInstanceInput label="Temperature" value={value} required />
```

## Keyboard Interactions

- Native `<input type="text">` keyboard behavior (typing, selection, clipboard)

## ARIA

- `aria-label` -- set from the `label` prop to provide an accessible name

## When to Use

- Use when the user needs to enter a specific measurement value with its unit, such as "72 kg" or "98.6 F".
- Use in medical, scientific, or engineering forms where recording measurement instances is required.
- Consider using MeasurementUnitInput and a NumberInput separately if the value and unit should be captured in distinct fields.

## Headless

This headless component provides a text input with `aria-label` for accessible naming and two-way bindable value for reactive form integration. The consumer provides all visual styling, including input dimensions, borders, placeholder text, and validation feedback appearance.

## Advice

- **Designers**: Include placeholder text showing the expected format (e.g., "72 kg") so users understand what to enter.
- **Developers**: Validate measurement format on the consumer side, as this component accepts free-text input without built-in format enforcement.

## Composition

MeasurementInstanceInput is part of the measurement component family. It works alongside MeasurementUnitInput, MeasurementUnitView, MeasurementSystemInput, MeasurementSystemView, and MeasurementInstanceView to cover input and display of measurement data.
