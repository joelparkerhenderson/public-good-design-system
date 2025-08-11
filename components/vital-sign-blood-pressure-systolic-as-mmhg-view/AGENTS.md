# Vital Sign Blood Pressure Systolic As Mmhg View

## Metadata

- Component: vital-sign-blood-pressure-systolic-as-mmhg-view
- PascalCase: VitalSignBloodPressureSystolicAsMmhgView
- Description: number display of one vital sign blood pressure systolic with integers
- HTML tag: <div>
- CSS class: .vital-sign-blood-pressure-systolic-as-mmhg-view
- Interactive: no

## Companion

- vital-sign-blood-pressure-systolic-as-mmhg-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "120 mmHg systolic")
- The `value` prop is the integer systolic blood pressure in mmHg
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignBloodPressureSystolicAsMmhgInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- systolic blood pressure value in mmHg
- `label`: string (required) -- accessible description via `aria-label` (e.g., "120 mmHg systolic")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-blood-pressure-systolic-as-mmhg-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-blood-pressure-systolic-as-mmhg-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-blood-pressure-systolic-as-mmhg-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- American Heart Association - Understanding Blood Pressure Readings: https://www.heart.org/en/health-topics/high-blood-pressure/understanding-blood-pressure-readings
