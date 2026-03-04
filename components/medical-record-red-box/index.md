# Medical Record Red Box

A medical record red box is a container for critical patient danger information. It uses `<aside role="alert">` with an aria-label to immediately announce urgent content to screen readers, such as life-threatening allergies or critical safety warnings.

This component is designed for healthcare applications where patient safety information must be communicated with maximum urgency. The `role="alert"` creates an implicit assertive live region, meaning screen readers will interrupt whatever they are currently reading to announce the danger box content as soon as it appears in the DOM.

## Implementation Notes

- Uses `<aside>` element with `role="alert"` for immediate screen reader announcements
- Designed for critical patient safety information such as life-threatening allergies
- `aria-label` provides the accessible name for the alert region
- `role="alert"` creates an implicit assertive live region (equivalent to `aria-live="assertive"`)
- Uses props rune for prop destructuring
- Uses `children` slot for flexible content rendering
- Spreads `...restProps` on the root `<aside>` element for consumer extensibility
- No hardcoded user-facing strings; all text comes through props and children

## Props

- `label`: string (required) -- accessible name for the danger box via `aria-label`
- `children`: slot (required) -- the danger box content
- `...restProps`: any additional HTML attributes spread onto the `<aside>` element

## Usage

```html
<MedicalRecordRedBox.md label="Critical allergy">
    <p>Patient has a life-threatening allergy to latex.</p>
</MedicalRecordRedBox.md>
```

## Keyboard Interactions

None -- alerts are passive announcements, not interactive elements. Content within the danger box (such as links or buttons) retains its own keyboard behavior.

## ARIA

- `role="alert"` -- creates an assertive live region that immediately announces content to screen readers
- `aria-label={label}` -- provides the accessible name for the alert region, set from the `label` prop

## When to Use

- Use to display critical patient safety information such as life-threatening allergies, dangerous drug interactions, or urgent clinical warnings.
- Use when the information must immediately interrupt screen reader users via an assertive live region.
- Avoid using for routine or non-critical information; overuse of `role="alert"` diminishes its urgency for assistive technology users.

## Headless

This headless component provides an `<aside>` with `role="alert"` for immediate assertive screen reader announcements and `aria-label` for accessible naming. The consumer provides all visual styling, including the red background, borders, iconography, and typography that convey urgency visually.

## Advice

- **Designers**: Use a bold red background with high-contrast white text and a warning icon to ensure the critical nature of the information is immediately apparent.
- **Developers**: Reserve this component for genuinely critical information. Assertive alerts interrupt the user, so misuse degrades the experience for screen reader users.

## References

- WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
