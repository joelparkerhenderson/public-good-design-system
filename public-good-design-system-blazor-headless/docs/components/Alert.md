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

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Type` | `string?` | `info` | HTML element type attribute |
| `Heading` | `string?` | `—` | The heading value |
| `Role` | `string?` | `alert` | The role value |
| `Live` | `string?` | `—` | The live value |
| `AriaLive` | `string?` | `—` | The aria live value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
@code {

}

<Alert>Something happened.</Alert>
```

With heading and error type:

```razor
<Alert type="error" heading="Error">Something went wrong. Please try again.</Alert>
```

Success notification:

```razor
<Alert type="success" heading="Saved">Your changes have been saved successfully.</Alert>
```

Polite status message using role="status":

```razor
<Alert role="status">Loading complete.</Alert>
```


## Keyboard Interactions

- None -- alerts are passive announcements, not interactive elements

## ARIA Attributes

- `role="alert"` or `role="status"` for live region semantics
- `aria-live="assertive"` (default for alert role) or `aria-live="polite"` (default for status role)
- `aria-atomic="true"` ensures the entire region is re-announced on any change

## References

- WAI-ARIA Alert Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/alert/
- WAI-ARIA alert role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA status role: https://www.w3.org/TR/wai-aria-1.2/#status
