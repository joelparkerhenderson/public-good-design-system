# VitalSignRespiratoryRateAsBreathsPerMinuteView

VitalSignRespiratoryRateAsBreathsPerMinuteView is a headless component that displays a read-only respiratory rate value in breaths per minute. It renders a `<span>` element with `role="img"` and an accessible label for screen readers.

This component is useful for patient dashboards, health records, medical monitoring interfaces, and any context where respiratory rate data needs to be displayed as a read-only value.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the respiratory rate value
- The `data-value` attribute enables consumer CSS styling based on value
- Spreads `$attrs` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- respiratory rate in breaths per minute
- `label`: string (required) -- accessible description via `aria-label` (e.g., "16 breaths per minute")
- `...$attrs`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```vue
<VitalSignRespiratoryRateAsBreathsPerMinuteView :value="16" label="16 breaths per minute" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- indicates the element represents a visual/graphic element
- `aria-label={label}` -- provides an accessible description of the respiratory rate value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
