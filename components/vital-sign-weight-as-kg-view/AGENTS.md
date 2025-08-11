# Vital Sign Weight As Kg View

## Metadata

- Component: vital-sign-weight-as-kg-view
- PascalCase: VitalSignWeightAsKgView
- Description: number display of one vital sign weight in kilograms with integers
- HTML tag: <div>
- CSS class: .vital-sign-weight-as-kg-view
- Interactive: no

## Companion

- vital-sign-weight-as-kg-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "75 kg weight")
- The `value` prop is the weight in kilograms as an integer
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignWeightAsKgInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- weight value in kilograms
- `label`: string (required) -- accessible description via `aria-label` (e.g., "75 kg weight")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-weight-as-kg-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-weight-as-kg-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-weight-as-kg-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- NHS - BMI healthy weight calculator: https://www.nhs.uk/live-well/healthy-weight/bmi-calculator/
