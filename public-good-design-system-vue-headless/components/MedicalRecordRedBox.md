# MedicalRecordRedBox.md

A medical patient banner danger box is a container for critical patient danger information. It uses `<aside role="alert">` with an aria-label to immediately announce urgent content to screen readers, such as life-threatening allergies or critical safety warnings.

This component is designed for healthcare applications where patient safety information must be communicated with maximum urgency. The `role="alert"` creates an implicit assertive live region, meaning screen readers will interrupt whatever they are currently reading to announce the danger box content as soon as it appears in the DOM.

## Implementation Notes

- Uses `<aside>` element with `role="alert"` for immediate screen reader announcements
- Designed for critical patient safety information such as life-threatening allergies
- `aria-label` provides the accessible name for the alert region
- `role="alert"` creates an implicit assertive live region (equivalent to `aria-live="assertive"`)
- Uses Svelte 5 `$props()` rune for prop destructuring
- Uses `children` Snippet for flexible content rendering
- Spreads `...restProps` on the root `<aside>` element for consumer extensibility
- No hardcoded user-facing strings; all text comes through props and children

## Props

- `label`: string (required) -- accessible name for the danger box via `aria-label`
- `children`: Snippet (required) -- the danger box content
- `...restProps`: any additional HTML attributes spread onto the `<aside>` element

## Usage

```svelte
<MedicalRecordRedBox.md label="Critical allergy">
    <p>Patient has a life-threatening allergy to latex.</p>
</MedicalRecordRedBox.md>
```

## Keyboard Interactions

None -- alerts are passive announcements, not interactive elements. Content within the danger box (such as links or buttons) retains its own keyboard behavior.

## ARIA

- `role="alert"` -- creates an assertive live region that immediately announces content to screen readers
- `aria-label={label}` -- provides the accessible name for the alert region, set from the `label` prop

## References

- WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
