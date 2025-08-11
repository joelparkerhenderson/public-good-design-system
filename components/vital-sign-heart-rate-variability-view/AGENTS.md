# Vital Sign Heart Rate Variability View

## Metadata

- Component: vital-sign-heart-rate-variability-view
- PascalCase: VitalSignHeartRateVariabilityView
- Description: number display of one vital sign heart rate variability (HRV) with integers
- HTML tag: <div>
- CSS class: .vital-sign-heart-rate-variability-view
- Interactive: no

## Companion

- vital-sign-heart-rate-variability-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "45 milliseconds HRV")
- The `value` prop is the integer HRV in milliseconds
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignHeartRateVariabilityInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- heart rate variability value in milliseconds
- `label`: string (required) -- accessible description via `aria-label` (e.g., "45 milliseconds HRV")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-heart-rate-variability-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-heart-rate-variability-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-heart-rate-variability-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- Harvard Health - Heart Rate Variability: https://www.health.harvard.edu/blog/heart-rate-variability-new-way-track-well-2017112212789
