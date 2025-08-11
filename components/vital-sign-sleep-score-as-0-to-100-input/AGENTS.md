# Vital Sign Sleep Score As 0 To 100 Input

## Metadata

- Component: vital-sign-sleep-score-as-0-to-100-input
- PascalCase: VitalSignSleepScoreAs0To100Input
- Description: number input of one vital sign sleep score with range 0-100
- HTML tag: <input>
- CSS class: .vital-sign-sleep-score-as-0-to-100-input
- Interactive: no

## Companion

- vital-sign-sleep-score-as-0-to-100-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial empty string state
- Default `min` is 0, `max` is 100, `step` is 1 (integers)
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization

## ARIA

- `aria-label={label}` -- provides an accessible name for the input

## Keyboard

Standard number input keyboard interactions provided natively by `<input type="number">`.

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | string (default: `""`) -- current value; bindable with two-way binding
- `min`: number (default: `0`) -- minimum valid value
- `max`: number (default: `100`) -- maximum valid value
- `step`: number (default: `1`) -- step increment (integers)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-sleep-score-as-0-to-100-input"
- [ ] Has aria-label attribute
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-sleep-score-as-0-to-100-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-sleep-score-as-0-to-100-input.html
- MDN input type="number": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
