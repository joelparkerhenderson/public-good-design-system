# VitalSignHeartRateBeatsPerMinuteView

VitalSignHeartRateBeatsPerMinuteView is a headless component that displays a read-only heart rate value in beats per minute (BPM). It renders a `<span>` element with `role="img"` and an accessible label for screen readers.

This component is useful for patient dashboards, health records, medical monitoring interfaces, and any context where heart rate data needs to be displayed as a read-only value.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the heart rate value
- The `data-value` attribute enables consumer CSS styling based on value
- Spreads `$attrs` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- heart rate in beats per minute
- `label`: string (required) -- accessible description via `aria-label` (e.g., "72 beats per minute")
- `...$attrs`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```vue
<VitalSignHeartRateBeatsPerMinuteView :value="72" label="72 beats per minute" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- indicates the element represents a visual/graphic element
- `aria-label={label}` -- provides an accessible description of the heart rate value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
