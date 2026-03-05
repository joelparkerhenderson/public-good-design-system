# VitalSignBloodPressureDiastolicView

VitalSignBloodPressureDiastolicView is a headless component that displays a read-only diastolic blood pressure value in millimeters of mercury (mmHg). It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the diastolic blood pressure
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- diastolic blood pressure value in mmHg
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignBloodPressureDiastolicView value={80} label="80 mmHg diastolic" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the diastolic blood pressure value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
