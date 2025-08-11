# Vital Sign Body Fat As Percentage View

## Metadata

- Component: vital-sign-body-fat-as-percentage-view
- PascalCase: VitalSignBodyFatAsPercentageView
- Description: number display of one vital sign body fat percentage with one decimal point
- HTML tag: <div>
- CSS class: .vital-sign-body-fat-as-percentage-view
- Interactive: no

## Companion

- vital-sign-body-fat-as-percentage-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "22.5 percent body fat")
- The `value` prop is the body fat percentage with one decimal point
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignBodyFatAsPercentageInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- body fat percentage value
- `label`: string (required) -- accessible description via `aria-label` (e.g., "22.5 percent body fat")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-body-fat-as-percentage-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-body-fat-as-percentage-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-body-fat-as-percentage-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- American Council on Exercise - Body Fat Percentages: https://www.acefitness.org/resources/everyone/tools-calculators/percent-body-fat-calculator/
