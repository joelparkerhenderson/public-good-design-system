# Vital Sign Body Temperature As Celcius Input

## Metadata

- Component: vital-sign-body-temperature-as-celcius-input
- PascalCase: VitalSignBodyTemperatureAsCelciusInput
- Description: number input of one vital sign body temperature in Celsius degrees with one decimal point
- HTML tag: <input>
- CSS class: .vital-sign-body-temperature-as-celcius-input
- Interactive: yes

## Companion

- vital-sign-body-temperature-as-celcius-view

## Key Behaviors

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Defaults: `min=30`, `max=45`, `step=0.1` for one-decimal-place Celsius entry
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization
- Companion to VitalSignBodyTemperatureAsCelciusView for the Input/View pattern

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the temperature input

## Keyboard

- Up Arrow: increment value by 0.1 (native browser behavior)
- Down Arrow: decrement value by 0.1 (native browser behavior)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current temperature value in °C; bindable with two-way binding
- `min`: number (default: `30`) -- minimum allowed value
- `max`: number (default: `45`) -- maximum allowed value
- `step`: number (default: `0.1`) -- increment step size (one decimal place)
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Acceptance Criteria

- [ ] Renders <input> element with class="vital-sign-body-temperature-as-celcius-input"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-body-temperature-as-celcius-input in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-body-temperature-as-celcius-input.html
- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role: https://www.w3.org/TR/wai-aria-1.2/#spinbutton
- MedlinePlus - Body Temperature Norms: https://medlineplus.gov/ency/article/001982.htm
