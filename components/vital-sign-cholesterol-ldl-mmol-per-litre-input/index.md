# Vital Sign Cholesterol LDL Mmol Per Litre Input

VitalSignCholesterolLdlMmolPerLitreInput is a headless number input for entering an LDL cholesterol value in millimoles per litre (mmol/L). It wraps a native `<input type="number">` with decimal-precision constraints and accessible labelling.

Use this component in medical forms, health assessments, and wellness applications where users need to enter an LDL cholesterol measurement.

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=10`, `step=0.1` for one-decimal-place mmol/L entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignCholesterolLdlMmolPerLitreView for the Input/View pattern

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current LDL value in mmol/L; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `10`) -- maximum allowed value
- `step`: number (default: `0.1`) -- increment step size (one decimal place)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```html
<VitalSignCholesterolLdlMmolPerLitreInput label="LDL cholesterol (mmol/L)" value={value} />
```

## Keyboard Interactions

- Up Arrow: increment value by 0.1 (native browser behavior)
- Down Arrow: decrement value by 0.1 (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the LDL cholesterol input

## When to Use

- Use for form fields that accept an LDL cholesterol measurement in mmol/L.
- Use as the input companion to VitalSignCholesterolLdlMmolPerLitreView.
- Consider using NumberInput for generic numeric values that are not specifically cholesterol.

## Headless

This headless component wraps a native `<input type="number">` with `aria-label`, two-way bindable value, and cholesterol-appropriate defaults (min=0, max=10, step=0.1). The consumer provides all visual styling.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-cholesterol-ldl-mmol-per-litre-input` class for targeting. Common styling includes displaying "mmol/L" as a suffix label.

## Testing

- Verify the component renders an `<input>` element with `type="number"`
- Verify `aria-label` is set from the `label` prop
- Verify default `min=0`, `max=10`, `step=0.1` attributes
- Verify `disabled` and `required` attributes propagate correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Display "mmol/L" as a unit label near the input. Use validation indicators to flag values at or above 3.0 mmol/L as high. Provide placeholder text like "2.5" to hint at the expected format.
- **Developers**: Use the default min/max/step constraints for standard LDL cholesterol entry. The step of 0.1 ensures one-decimal-place precision.

## Domain Knowledge

LDL (low-density lipoprotein) is known as "bad cholesterol" because high levels can lead to plaque buildup in arteries. A healthy LDL level is below 3.0 mmol/L.

- Healthy Level: Below 3.0 mmol/L.
- Management: Reduce saturated fats and increase fiber and oily fish intake. Increase intake of nuts, seeds, fruits, vegetables, and whole grains.
- Avoid: High amounts of red meat, processed meats, full-fat dairy, and foods containing coconut or palm oil.
- Risk: High LDL levels increase risk of heart disease, stroke, and peripheral artery disease.

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- NHS - High Cholesterol: https://www.nhs.uk/conditions/high-cholesterol/
