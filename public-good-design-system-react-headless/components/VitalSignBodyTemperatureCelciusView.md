# VitalSignBodyTemperatureCelciusView

VitalSignBodyTemperatureCelciusView is a headless component that displays a read-only body temperature value in degrees Celsius. It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the body temperature
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- body temperature value in degrees Celsius
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignBodyTemperatureCelciusView value={37.0} label="37.0 degrees Celsius" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the body temperature value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
