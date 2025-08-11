# Vital Sign VO2 Max As Ml Per Kg Per Minute Input

## Metadata

- Component: vital-sign-vo2-max-as-ml-per-kg-per-minute-input
- PascalCase: VitalSignVo2MaxAsMlPerKgPerMinuteInput
- Description: number input of one vital sign VO2 max in millilitres per kilogram per minute with integers
- HTML tag: <input>
- CSS class: .vital-sign-vo2-max-as-ml-per-kg-per-minute-input
- Interactive: yes

## Companion

- vital-sign-vo2-max-as-ml-per-kg-per-minute-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=100`, `step=1` for integer-only ml/kg/min entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignVO2MaxMlPerKgPerMinuteView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the VO2 max input

## Keyboard

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current VO2 max value in ml/kg/min; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `100`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (integer)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-vo2-max-as-ml-per-kg-per-minute-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-vo2-max-as-ml-per-kg-per-minute-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-vo2-max-as-ml-per-kg-per-minute-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- American College of Sports Medicine - VO2 Max: https://www.acsm.org/
