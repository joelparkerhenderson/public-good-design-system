# Vital Sign Cholesterol As HDL Mmol Per Litre View

## Metadata

- Component: vital-sign-cholesterol-as-hdl-mmol-per-litre-view
- PascalCase: VitalSignCholesterolAsHdlMmolPerLitreView
- Description: number display of one vital sign cholesterol HDL (good cholesterol) millimole per litre with one decimal point
- HTML tag: <div>
- CSS class: .vital-sign-cholesterol-as-hdl-mmol-per-litre-view
- Interactive: no

## Companion

- vital-sign-cholesterol-as-hdl-mmol-per-litre-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only numeric display
- Uses `aria-label` for an accessible description (e.g., "1.5 mmol/L HDL cholesterol")
- The `value` prop is the HDL cholesterol in mmol/L with one decimal point
- Spreads `restProps` onto the span for consumer customization
- Companion to VitalSignCholesterolAsHdlMmolPerLitreInput for the Input/View pattern

## ARIA

- `role="img"` -- identifies the span as a visual/graphic display element
- `aria-label={label}` -- provides the full value description for screen readers

## Props

- `value`: number (required) -- HDL cholesterol value in mmol/L
- `label`: string (required) -- accessible description via `aria-label` (e.g., "1.5 mmol/L HDL cholesterol")
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-cholesterol-as-hdl-mmol-per-litre-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-cholesterol-as-hdl-mmol-per-litre-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-cholesterol-as-hdl-mmol-per-litre-view.html
- WAI-ARIA img role: https://www.w3.org/WAI/ARIA/apd/roles/img/
- NHS - High Cholesterol: https://www.nhs.uk/conditions/high-cholesterol/
