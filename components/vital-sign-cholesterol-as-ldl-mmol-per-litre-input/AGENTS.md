# Vital Sign Cholesterol As LDL Mmol Per Litre Input

## Metadata

- Component: vital-sign-cholesterol-as-ldl-mmol-per-litre-input
- PascalCase: VitalSignCholesterolAsLdlMmolPerLitreInput
- Description: number input of one vital sign cholesterol LDL (bad cholesterol) millimole per litre with one decimal point
- HTML tag: <input>
- CSS class: .vital-sign-cholesterol-as-ldl-mmol-per-litre-input
- Interactive: yes

## Companion

- vital-sign-cholesterol-as-ldl-mmol-per-litre-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=10`, `step=0.1` for one-decimal-place mmol/L entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignCholesterolAsLdlMmolPerLitreView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the LDL cholesterol input

## Keyboard

- Up Arrow: increment value by 0.1 (native browser behavior)
- Down Arrow: decrement value by 0.1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current LDL value in mmol/L; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `10`) -- maximum allowed value
- `step`: number (default: `0.1`) -- increment step size (one decimal place)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-cholesterol-as-ldl-mmol-per-litre-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-cholesterol-as-ldl-mmol-per-litre-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-cholesterol-as-ldl-mmol-per-litre-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- NHS - High Cholesterol: https://www.nhs.uk/conditions/high-cholesterol/
