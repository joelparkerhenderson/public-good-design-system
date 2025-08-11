# Vital Sign Height As Cm View

## Metadata

- Component: vital-sign-height-as-cm-view
- PascalCase: VitalSignHeightAsCmView
- Description: number display of one vital sign height in centimetres with integers
- HTML tag: <div>
- CSS class: .vital-sign-height-as-cm-view
- Interactive: no

## Companion

- vital-sign-height-as-cm-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "175 cm height")
- The `value` prop is the height in centimetres as an integer
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignHeightAsCmInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- height value in centimetres
- `label`: string (required) -- accessible description via `aria-label` (e.g., "175 cm height")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-height-as-cm-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-height-as-cm-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-height-as-cm-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- NHS - BMI healthy weight calculator: https://www.nhs.uk/live-well/healthy-weight/bmi-calculator/
