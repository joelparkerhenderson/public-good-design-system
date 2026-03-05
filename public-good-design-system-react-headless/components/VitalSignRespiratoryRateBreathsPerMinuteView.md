# VitalSignRespiratoryRateBreathsPerMinuteView

VitalSignRespiratoryRateBreathsPerMinuteView is a headless component that displays a read-only respiratory rate value in breaths per minute. It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the respiratory rate
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- respiratory rate value in breaths per minute
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignRespiratoryRateBreathsPerMinuteView value={16} label="16 breaths per minute" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the respiratory rate value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
