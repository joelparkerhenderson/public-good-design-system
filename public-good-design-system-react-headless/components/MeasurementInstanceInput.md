# MeasurementInstanceInput

A measurement instance input provides a text field for entering a specific measurement value, such as "72 kg", "98.6 F", or "120/80 mmHg". A measurement instance represents an individual recorded measurement with both its numeric value and unit.

The component uses `aria-label` for accessible labeling in a headless context, and the `value` prop is two-way controlled for reactive form integration. It supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Uses `<input type="text">` with `aria-label` for accessible naming
- A measurement instance is a specific measured value (e.g., "72 kg", "98.6 F")
- The `value` prop supports controlled component usage
- Supports `required` and `disabled` HTML attributes
- Spreads `...restProps` on the root `<input>` element
- All text content comes through props for internationalization

## Props

- `label`: string (required) -- accessible name via `aria-label`
- `value`: string (default: "", controlled) -- controlled measurement instance value
- `required`: boolean (default: false) -- whether the field is required
- `disabled`: boolean (default: false) -- whether the field is disabled
- `...restProps`: Any additional HTML attributes passed to the `<input>` element

## Usage

```tsx
<MeasurementInstanceInput label="Weight" value + onChange />
<MeasurementInstanceInput label="Temperature" value + onChange required />
```

## Keyboard Interactions

- Native `<input type="text">` keyboard behavior (typing, selection, clipboard-copy-button)

## ARIA

- `aria-label` -- set from the `label` prop to provide an accessible name
