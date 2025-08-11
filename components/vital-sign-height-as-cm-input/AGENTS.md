# Vital Sign Height As Cm Input

## Metadata

- Component: vital-sign-height-as-cm-input
- PascalCase: VitalSignHeightAsCmInput
- Description: number input of one vital sign height in centimetres with integers
- HTML tag: <input>
- CSS class: .vital-sign-height-as-cm-input
- Interactive: yes

## Companion

- vital-sign-height-as-cm-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=300`, `step=1` for whole-number centimetre entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignHeightAsCmView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the height input

## Keyboard

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current height value in cm; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `300`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (whole numbers)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-height-as-cm-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-height-as-cm-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-height-as-cm-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- NHS - BMI healthy weight calculator: https://www.nhs.uk/live-well/healthy-weight/bmi-calculator/
