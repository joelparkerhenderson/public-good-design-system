# Badge

A badge is a small inline component for displaying dynamic status information, counts, or short labels in a compact, prominent format. Badges are commonly used to show unread message counts, notification indicators, or activity statuses attached to icons, buttons, or list items.

The component renders as a `<span>` with `role="status"`, creating an ARIA live region that announces content changes to screen readers. The `data-type` attribute exposes the semantic variant for consumer CSS styling, and an optional `aria-label` provides expanded context when the visible badge text alone is insufficient (e.g., "3" displayed visually but "3 unread messages" announced to screen readers).

## Implementation Notes

- Renders as `<span role="status">` for screen reader announcements of dynamic content
- `data-type` attribute exposes variant for consumer CSS styling
- `aria-label` provides expanded context when badge text alone is insufficient
- Five semantic variants: default, info, success, warning, error
- Content is provided through the Blazor 5 `ChildContent` RenderFragment

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Type` | `string?` | `default` | HTML element type attribute |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Badge>New</Badge>
<Badge label="3 unread messages">3</Badge>
<Badge type="warning">Alert</Badge>
```


## Keyboard Interactions

- None -- badges are informational, not interactive

## ARIA Attributes

- `role="status"` -- creates an ARIA live region for dynamic content announcements
- `aria-label` -- optional expanded context for screen readers beyond the visible text
