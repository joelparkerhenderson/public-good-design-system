# Alert

An alert is a UI/UX component designed to capture the user's attention and
convey important information, such as warnings, errors, confirmations, or status
updates. Alerts interrupt the user's workflow to ensure visibility and are
commonly used for critical feedback or decision points -- such as confirming
deletion or notifying of failed actions. They should be clear, concise, and
appropriately styled (e.g., color-coded for severity by the consumer) to avoid
confusion or unnecessary disruption.

This component renders as a `<div>` with ARIA live region attributes for
automatic screen reader announcements. It supports different severity types
(info, success, warning, error) exposed via a `data-type` attribute that
consumers can use for styling. An optional heading is rendered with `<strong>`
emphasis without assuming a heading level.

## Implementation Notes

- Uses `role="alert"` with `aria-live="assertive"` by default for immediate screen reader announcements
- Supports `role="status"` with `aria-live="polite"` for less urgent messages
- `aria-atomic="true"` ensures the entire alert is re-read when content changes
- `data-type` attribute exposes severity type for CSS styling by consumers
- Heading rendered as `<p><strong>` for semantic emphasis without assuming heading level
- The `live` prop can override the default aria-live value derived from the role

## Props

- `type`: "info" | "success" | "warning" | "error" (default: "info") -- severity type
- `heading`: string (optional) -- heading text for the alert
- `role`: "alert" | "status" (default: "alert") -- ARIA role
- `live`: "assertive" | "polite" | "off" (optional) -- override for aria-live politeness
- `children`: slot (required) -- the alert content
- `...restProps`: Any additional HTML attributes spread onto the `<div>`

## Usage

```html
<Alert>Something happened.</Alert>
```

With heading and error type:

```html
<Alert type="error" heading="Error">Something went wrong. Please try again.</Alert>
```

Success notification:

```html
<Alert type="success" heading="Saved">Your changes have been saved successfully.</Alert>
```

Polite status message using role="status":

```html
<Alert role="status">Loading complete.</Alert>
```

## Keyboard Interactions

- None -- alerts are passive announcements, not interactive elements

## ARIA

- `role="alert"` or `role="status"` for live region semantics
- `aria-live="assertive"` (default for alert role) or `aria-live="polite"` (default for status role)
- `aria-atomic="true"` ensures the entire region is re-announced on any change

## When to Use

- Use for displaying important feedback messages such as form validation errors, success confirmations, warnings, or system status updates.
- Use when the message should be announced immediately to screen reader users via a live region.
- Avoid for persistent page-level announcements -- use Banner instead.
- Consider AlertDialog instead when the message requires user acknowledgment before continuing.

## Headless

This component provides ARIA live region semantics (`role="alert"` or `role="status"`), `aria-atomic`, and a `data-type` attribute for severity variants, with zero visual styling. The consumer is responsible for all CSS including background colors, border styles, icons, typography, and spacing for each severity level.


## Styles

The consumer provides all CSS styling. The component renders with a `.alert` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `alert`
- Verify role="alert"` or `role="status"` for live region semantics
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use consistent color coding across severity types (info, success, warning, error) and pair colors with icons so that meaning is not conveyed by color alone.
- **Developers**: Use `role="alert"` with `aria-live="assertive"` for critical messages and `role="status"` with `aria-live="polite"` for non-urgent updates to avoid disrupting the user unnecessarily.

## References

- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
- WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA status role: https://www.w3.org/TR/wai-aria-1.2/#status
