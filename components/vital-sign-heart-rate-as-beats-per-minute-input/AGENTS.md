# Vital Sign Heart Rate As Beats Per Minute Input

## Metadata

- Component: vital-sign-heart-rate-as-beats-per-minute-input
- PascalCase: VitalSignHeartRateAsBeatsPerMinuteInput
- Description: number input of one vital sign heart rate in beats per minute (BPM) with integers
- HTML tag: <input>
- CSS class: .vital-sign-heart-rate-as-beats-per-minute-input
- Interactive: yes

## Companion

- vital-sign-heart-rate-as-beats-per-minute-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=300`, `step=1` for integer-only BPM entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignHeartRateAsBeatsPerMinuteView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the heart rate input

## Keyboard

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current BPM value; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `300`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (integer)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-heart-rate-as-beats-per-minute-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-heart-rate-as-beats-per-minute-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-heart-rate-as-beats-per-minute-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- American Heart Association - Target Heart Rates: https://www.heart.org/en/healthy-living/fitness/fitness-basics/target-heart-rates
