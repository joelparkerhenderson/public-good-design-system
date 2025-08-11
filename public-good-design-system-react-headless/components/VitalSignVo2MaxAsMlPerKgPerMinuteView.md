# VitalSignVO2MaxMlPerKgPerMinuteView

VitalSignVO2MaxMlPerKgPerMinuteView is a headless component that displays a read-only VO2 max value in milliliters per kilogram per minute (ml/kg/min). It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the VO2 max
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- VO2 max value in ml/kg/min
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignVO2MaxMlPerKgPerMinuteView value={42} label="42 ml/kg/min VO2 max" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the VO2 max value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
