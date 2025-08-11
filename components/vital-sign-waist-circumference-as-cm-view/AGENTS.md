# Vital Sign Waist Circumference As Cm View

## Metadata

- Component: vital-sign-waist-circumference-as-cm-view
- PascalCase: VitalSignWaistCircumferenceAsCmView
- Description: number display of one vital sign waist circumference in centimetres with integers
- HTML tag: <div>
- CSS class: .vital-sign-waist-circumference-as-cm-view
- Interactive: no

## Companion

- vital-sign-waist-circumference-as-cm-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "94 cm waist circumference")
- The `value` prop is the waist circumference in centimetres as an integer
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignWaistCircumferenceAsCmInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- waist circumference value in centimetres
- `label`: string (required) -- accessible description via `aria-label` (e.g., "94 cm waist circumference")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-waist-circumference-as-cm-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-waist-circumference-as-cm-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-waist-circumference-as-cm-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- NHS - Health risks of obesity: https://www.nhs.uk/conditions/obesity/
- WHO - Waist Circumference and Waist-Hip Ratio: https://www.who.int/publications/i/item/9789241501491
