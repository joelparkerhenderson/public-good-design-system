# Vital Sign Respiratory Rate As Breaths Per Minute Input

## Metadata

- Component: vital-sign-respiratory-rate-as-breaths-per-minute-input
- PascalCase: VitalSignRespiratoryRateAsBreathsPerMinuteInput
- Description: number input of one vital sign respiratory rate in breaths per minute with integers
- HTML tag: <input>
- CSS class: .vital-sign-respiratory-rate-as-breaths-per-minute-input
- Interactive: yes

## Companion

- vital-sign-respiratory-rate-as-breaths-per-minute-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=100`, `step=1` for integer-only bpm entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignRespiratoryRateAsBreathsPerMinuteView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the respiratory rate input

## Keyboard

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current bpm value; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `100`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (integer)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-respiratory-rate-as-breaths-per-minute-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-respiratory-rate-as-breaths-per-minute-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-respiratory-rate-as-breaths-per-minute-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- MedlinePlus - Breathing Rate: https://medlineplus.gov/ency/article/002020.htm
