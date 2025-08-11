# Medical Record Red Box

## Metadata

- Component: medical-record-red-box
- PascalCase: MedicalRecordRedBox
- Description: a red highlighted box for critical medical record information
- HTML tag: <div>
- CSS class: .medical-record-red-box
- Interactive: no

## Key Behaviors

- Uses `<aside>` element with `role="alert"` for immediate screen reader announcements
- Designed for critical patient safety information such as life-threatening allergies
- `aria-label` provides the accessible name for the alert region
- `role="alert"` creates an implicit assertive live region (equivalent to `aria-live="assertive"`)
- Uses props rune for prop destructuring
- Uses `children` slot for flexible content rendering
- Spreads `...restProps` on the root `<aside>` element for consumer extensibility
- No hardcoded user-facing strings; all text comes through props and children

## ARIA

- `role="alert"` -- creates an assertive live region that immediately announces content to screen readers
- `aria-label={label}` -- provides the accessible name for the alert region, set from the `label` prop

## Props

- `label`: string (required) -- accessible name for the danger box via `aria-label`
- `children`: slot (required) -- the danger box content
- `...restProps`: any additional HTML attributes spread onto the `<aside>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="medical-record-red-box"
- [ ] Has aria-label attribute
- [ ] Has role="alert"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .medical-record-red-box in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/medical-record-red-box.html
- WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
