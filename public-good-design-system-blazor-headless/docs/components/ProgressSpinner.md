# ProgressSpinner

A progress spinner indicates an ongoing loading or processing state where the completion time is unknown. Unlike ProgressCircle which shows a specific percentage, a spinner indicates indeterminate loading. It uses `role="status"` and `aria-live="polite"` to announce the loading state to screen readers without interrupting the user. The component is headless, allowing consumers to apply their own spinning animation via CSS.

## Implementation Notes

- Renders a `<div>` with `role="status"` for implicit live region semantics
- Uses `aria-live="polite"` to ensure screen readers announce the loading state without interruption
- Provides `aria-label` for accessible naming of the loading state
- Accepts an optional `ChildContent` RenderFragment for content inside (e.g., loading text)
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment?` | `—` | Child content to render inside the component |

## Usage


```razor
<ProgressSpinner label="Loading data" />
```


## Keyboard Interactions

None -- this component is a passive, read-only status indicator.

## ARIA Attributes

- `role="status"` -- identifies the element as a status region that receives non-urgent updates
- `aria-label="..."` -- provides an accessible name describing what is loading
- `aria-live="polite"` -- ensures content changes are announced by screen readers at the next opportunity without interrupting

## References

- WAI-ARIA `status` role: https://www.w3.org/WAI/ARIA/apd/roles/status/
- MDN `aria-live`: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Attributes/aria-live
