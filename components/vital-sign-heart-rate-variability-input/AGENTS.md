# Vital Sign Heart Rate Variability Input

## Metadata

- Component: vital-sign-heart-rate-variability-input
- PascalCase: VitalSignHeartRateVariabilityInput
- Description: number input of one vital sign heart rate variability (HRV) with integers
- HTML tag: <input>
- CSS class: .vital-sign-heart-rate-variability-input
- Interactive: yes

## Companion

- vital-sign-heart-rate-variability-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=0`, `max=500`, `step=1` for integer-only millisecond entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignHeartRateVariabilityView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the HRV input

## Keyboard

- Up Arrow: increment value by 1 (native browser behavior)
- Down Arrow: decrement value by 1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current HRV value in milliseconds; bindable with two-way binding
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `500`) -- maximum allowed value
- `step`: number (default: `1`) -- increment step size (integer)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-heart-rate-variability-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-heart-rate-variability-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-heart-rate-variability-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- Harvard Health - Heart Rate Variability: https://www.health.harvard.edu/blog/heart-rate-variability-new-way-track-well-2017112212789
