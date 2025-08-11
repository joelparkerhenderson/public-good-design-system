# VitalSignBodyFatAsPercentageView

VitalSignBodyFatAsPercentageView is a headless component that displays a read-only body fat percentage value. It renders a `<span>` element with `role="img"` and an accessible label for screen readers.

This component is useful for patient dashboards, health records, fitness tracking interfaces, wellness monitoring applications, and any context where body fat percentage data needs to be displayed as a read-only value.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the body fat percentage value
- The `data-value` attribute enables consumer CSS styling based on value
- Spreads `$attrs` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- body fat percentage value
- `label`: string (required) -- accessible description via `aria-label` (e.g., "22.5 percent body fat")
- `...$attrs`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```vue
<VitalSignBodyFatAsPercentageView :value="22.5" label="22.5 percent body fat" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- indicates the element represents a visual/graphic element
- `aria-label={label}` -- provides an accessible description of the body fat percentage value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
