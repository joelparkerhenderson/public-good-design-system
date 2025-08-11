# Vital Sign Body Temperature As Celcius View

## Metadata

- Component: vital-sign-body-temperature-as-celcius-view
- PascalCase: VitalSignBodyTemperatureAsCelciusView
- Description: number display of one vital sign body temperature in Celsius degrees with one decimal point
- HTML tag: <div>
- CSS class: .vital-sign-body-temperature-as-celcius-view
- Interactive: no

## Companion

- vital-sign-body-temperature-as-celcius-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "37.0 degrees Celsius")
- The `value` prop is the temperature in degrees Celsius with one decimal point
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignBodyTemperatureAsCelciusInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- body temperature value in degrees Celsius
- `label`: string (required) -- accessible description via `aria-label` (e.g., "37.0 degrees Celsius")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-body-temperature-as-celcius-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-body-temperature-as-celcius-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-body-temperature-as-celcius-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- MedlinePlus - Body Temperature Norms: https://medlineplus.gov/ency/article/001982.htm
