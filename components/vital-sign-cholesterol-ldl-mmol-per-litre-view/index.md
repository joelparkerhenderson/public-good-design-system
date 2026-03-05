# Vital Sign Cholesterol LDL Mmol Per Litre View

VitalSignCholesterolLdlMmolPerLitreView is a headless read-only display of an LDL cholesterol value in millimoles per litre (mmol/L). It renders a `<span>` with `role="img"` and an accessible label describing the value and unit.

Use this component to display a patient's LDL ("bad cholesterol") level in medical records, health dashboards, vital sign summaries, and wellness applications.

## Implementation Notes

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "2.5 mmol/L LDL cholesterol")
- The `value` prop is the LDL cholesterol in mmol/L with one decimal point
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignCholesterolLdlMmolPerLitreInput for the Input/View pattern

## Props

- `value`: number (required) -- LDL cholesterol value in mmol/L
- `label`: string (required) -- accessible description via `aria-label` (e.g., "2.5 mmol/L LDL cholesterol")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```html
<VitalSignCholesterolLdlMmolPerLitreView value={2.5} label="2.5 mmol/L LDL cholesterol" />
```

## Keyboard Interactions

None. This is a passive, read-only display element.

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## When to Use

- Use to display an LDL cholesterol reading in vital sign summaries, medical records, or health dashboards.
- Use as the display companion to VitalSignCholesterolLdlMmolPerLitreInput.
- Avoid using for editable cholesterol values; use VitalSignCholesterolLdlMmolPerLitreInput instead.

## Headless

This headless component provides a `<span>` with `role="img"` and `aria-label`. The consumer provides all visual styling including font size, color coding for healthy/unhealthy ranges, and unit label display.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-cholesterol-ldl-mmol-per-litre-view` class for targeting. Common styling includes color coding for ranges (green for healthy <3.0 mmol/L, red for high >=3.0 mmol/L).

## Testing

- Verify the component renders a `<span>` element with `role="img"`
- Verify `aria-label` is set from the `label` prop
- Verify the `value` is displayed as text content
- Verify `data-value` attribute is set
- Verify pass-through attributes are applied

## Advice

- **Designers**: Display "mmol/L" as a unit label alongside the number. Use color coding to indicate healthy (below 3.0 mmol/L) and high (3.0 mmol/L or above) ranges. Show one decimal place for precision.
- **Developers**: The `label` prop should include both the value and unit for screen readers (e.g., "2.5 mmol/L LDL cholesterol"). Consider using `data-value` for conditional CSS styling based on range.

## Domain Knowledge

LDL (low-density lipoprotein) is known as "bad cholesterol" because high levels can lead to plaque buildup in arteries. A healthy LDL level is below 3.0 mmol/L.

- Healthy Level: Below 3.0 mmol/L.
- Management: Reduce saturated fats and increase fiber and oily fish intake. Increase intake of nuts, seeds, fruits, vegetables, and whole grains.
- Avoid: High amounts of red meat, processed meats, full-fat dairy, and foods containing coconut or palm oil.
- Risk: High LDL levels increase risk of heart disease, stroke, and peripheral artery disease.

## References

- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- NHS - High Cholesterol: https://www.nhs.uk/conditions/high-cholesterol/
