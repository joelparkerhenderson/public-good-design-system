# Vital Sign VO2 Max As Ml Per Kg Per Minute View

## Metadata

- Component: vital-sign-vo2-max-as-ml-per-kg-per-minute-view
- PascalCase: VitalSignVo2MaxAsMlPerKgPerMinuteView
- Description: number display of one vital sign VO2 max in millilitres per kilogram per minute with integers
- HTML tag: <div>
- CSS class: .vital-sign-vo2-max-as-ml-per-kg-per-minute-view
- Interactive: no

## Companion

- vital-sign-vo2-max-as-ml-per-kg-per-minute-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "42 ml/kg/min VO2 max")
- The `value` prop is the integer VO2 max in ml/kg/min
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignVO2MaxMlPerKgPerMinuteInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- VO2 max value in ml/kg/min
- `label`: string (required) -- accessible description via `aria-label` (e.g., "42 ml/kg/min VO2 max")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-vo2-max-as-ml-per-kg-per-minute-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-vo2-max-as-ml-per-kg-per-minute-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-vo2-max-as-ml-per-kg-per-minute-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- American College of Sports Medicine - VO2 Max: https://www.acsm.org/
