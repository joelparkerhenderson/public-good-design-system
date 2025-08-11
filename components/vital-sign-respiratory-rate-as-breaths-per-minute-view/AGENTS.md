# Vital Sign Respiratory Rate As Breaths Per Minute View

## Metadata

- Component: vital-sign-respiratory-rate-as-breaths-per-minute-view
- PascalCase: VitalSignRespiratoryRateAsBreathsPerMinuteView
- Description: number display of one vital sign respiratory rate in breaths per minute with integers
- HTML tag: <div>
- CSS class: .vital-sign-respiratory-rate-as-breaths-per-minute-view
- Interactive: no

## Companion

- vital-sign-respiratory-rate-as-breaths-per-minute-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "16 breaths per minute")
- The `value` prop is the integer respiratory rate in breaths per minute
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignRespiratoryRateAsBreathsPerMinuteInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- respiratory rate value in breaths per minute
- `label`: string (required) -- accessible description via `aria-label` (e.g., "16 breaths per minute")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-respiratory-rate-as-breaths-per-minute-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-respiratory-rate-as-breaths-per-minute-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-respiratory-rate-as-breaths-per-minute-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- MedlinePlus - Breathing Rate: https://medlineplus.gov/ency/article/002020.htm
