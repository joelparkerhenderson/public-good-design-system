# Toast

A toast is a UI/UX component that provides a brief, transient notification message to the user. It uses `role="status"` with `aria-live="polite"` by default, or `role="alert"` with `aria-live="assertive"` for urgent messages. Toasts are typically displayed temporarily to confirm actions, report errors, or provide status updates without requiring user interaction.

Toasts are similar to notifications but are generally more ephemeral and less intrusive. They are commonly used for success confirmations ("Item saved"), error messages ("Connection lost"), and informational updates ("New message received").

## Implementation Notes

- Renders a `<div>` element with a live region role for screen reader announcements
- Uses conditional role assignment: `role="status"` for normal messages, `role="alert"` for urgent ones
- Uses conditional `aria-live`: `"polite"` waits for a pause in speech, `"assertive"` interrupts immediately
- The `urgent` prop controls both the role and aria-live behavior simultaneously
- Accepts a `ChildContent` RenderFragment for flexible toast content
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `class`)
- Blazor 5 RenderFragment pattern used for the `ChildContent` prop (imported from "svelte")

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string?` | `—` | Accessible label for the component |
| `Urgent` | `bool` | `—` | The urgent value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Toast label="Success">Your changes have been saved.</Toast>
```


```razor
<Toast label="Error" urgent>Something went wrong.</Toast>
```


```razor
<Toast label="Info">
  <p>3 new messages in your inbox.</p>
</Toast>
```


## Keyboard Interactions

None -- this component is a passive notification container. Toasts are announced by screen readers through live regions and do not receive keyboard focus.

## ARIA Attributes

- `role="status"` -- (default) identifies a live region with advisory information, announced at the next graceful opportunity
- `role="alert"` -- (when `urgent` is true) identifies a live region with important, time-sensitive information, announced immediately
- `aria-live="polite"` -- (default) screen reader waits for a pause before announcing the content
- `aria-live="assertive"` -- (when `urgent` is true) screen reader interrupts current speech to announce the content
- `aria-label={label}` -- optional descriptive label for the toast region

## References

- WAI-ARIA Alert Role: https://www.w3.org/TR/wai-aria-1.2/#alert
- WAI-ARIA Status Role: https://www.w3.org/TR/wai-aria-1.2/#status
- WAI-ARIA Live Regions: https://www.w3.org/TR/wai-aria-1.2/#aria-live
