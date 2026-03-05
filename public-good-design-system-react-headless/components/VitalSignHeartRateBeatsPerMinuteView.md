# VitalSignHeartRateBeatsPerMinuteView

VitalSignHeartRateBeatsPerMinuteView is a headless component that displays a read-only heart rate value in beats per minute (BPM). It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the heart rate
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- heart rate value in beats per minute
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignHeartRateBeatsPerMinuteView value={72} label="Heart rate: 72 BPM" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the heart rate value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
