# VitalSignBloodPressureDiastolicView

VitalSignBloodPressureDiastolicView is a headless component that displays a read-only diastolic blood pressure value in millimeters of mercury (mmHg). It renders a `<span>` element with `role="img"` and an accessible label for screen readers.

This component is useful for patient dashboards, health records, medical monitoring interfaces, and any context where diastolic blood pressure data needs to be displayed as a read-only value.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the diastolic blood pressure value
- The `data-value` attribute enables consumer CSS styling based on value
- Spreads `$attrs` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- diastolic blood pressure in mmHg
- `label`: string (required) -- accessible description via `aria-label` (e.g., "80 mmHg diastolic")
- `...$attrs`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```vue
<VitalSignBloodPressureDiastolicView :value="80" label="80 mmHg diastolic" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- indicates the element represents a visual/graphic element
- `aria-label={label}` -- provides an accessible description of the diastolic blood pressure value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
