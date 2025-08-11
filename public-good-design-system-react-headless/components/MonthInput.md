# MonthInput

MonthInput is a headless component that wraps a native `<input type="month">` element with accessible labelling for selecting a month and year. It provides a controlled value and supports common form input states like required and disabled.

This component is useful for date-related forms where the user needs to select a specific month, such as credit card expiration dates, report periods, billing cycles, or start/end dates at month granularity. The native month input provides a browser-provided picker interface where supported.

## Implementation Notes

- Renders a native `<input type="month">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop supports controlled component usage, storing the month in `YYYY-MM` format
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization (e.g., `min`, `max`, `id`, `name`)
- Supports controlled component usage for the value prop

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: string (default: `""`) -- current month value in `YYYY-MM` format; controlled with `value + onChange`
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```tsx
<MonthInput label="Start month" value + onChange />
```

## Keyboard Interactions

None at the component level. Keyboard behavior is handled natively by the browser's month input implementation.

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the month input

## References

- HTML month input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/month
