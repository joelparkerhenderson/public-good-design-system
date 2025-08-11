# VitalSignCholesterolAsHdlMmolPerLitreView

VitalSignCholesterolAsHdlMmolPerLitreView is a headless component that displays a read-only HDL cholesterol value in millimoles per litre. It renders a `<span>` with `role="img"` and an accessible `aria-label` for screen readers.

## Implementation Notes

- Renders a `<span>` element with `role="img"`
- Uses `aria-label` for an accessible description of the HDL cholesterol level
- The `value` prop is displayed as text content and set on `data-value`
- Spreads `restProps` onto the span for consumer customization (e.g., `id`, `data-testid`)

## Props

- `value`: number (required) -- HDL cholesterol value in mmol/L
- `label`: string (required) -- accessible description via `aria-label`
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```tsx
<VitalSignCholesterolAsHdlMmolPerLitreView value={1.5} label="1.5 mmol/L HDL cholesterol" />
```

## ARIA

- `role="img"` -- indicates the element represents a visual display
- `aria-label={label}` -- provides an accessible description of the HDL cholesterol value

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
