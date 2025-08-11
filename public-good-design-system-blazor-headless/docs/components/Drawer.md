# Drawer

A drawer is a panel that slides in from an edge of the viewport, typically used for navigation menus, filters, or supplementary content. It overlays the main content and can be dismissed by the user. The component renders conditionally based on its `open` state and uses `role="dialog"` with `aria-modal="true"` for proper screen reader behavior.

The `side` prop indicates which edge the drawer enters from via a `data-side` attribute, allowing consumers to apply appropriate positioning and animation styles. The drawer supports keyboard dismissal with the Escape key and provides a `tabindex="-1"` to allow programmatic focus management.

## Implementation Notes

- Conditionally renders a `<div>` with `role="dialog"` only when `open` is true
- Uses `@bind-` on the `open` prop for two-way state binding
- Sets `aria-modal="true"` to indicate the drawer is a modal dialog
- Exposes `data-side` attribute for consumer CSS positioning (left, right, top, bottom)
- Sets `tabindex="-1"` to allow the drawer to receive focus programmatically
- Escape key handler sets `open` to `false`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `Label` | `string` | `—` | Accessible label for the component |
| `Side` | `string?` | `left` | The side value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Drawer label="Navigation" @bind-Open side="left">
  <nav>...</nav>
</Drawer>
```


```razor
<Drawer label="Filters" @bind-Open="showFilters" side="right">
  <form>...</form>
</Drawer>
```


## Keyboard Interactions

- Escape: closes the drawer by setting `open` to `false`

## ARIA Attributes

- `role="dialog"` -- identifies the drawer as a dialog for assistive technology
- `aria-label={label}` -- provides an accessible name for the dialog
- `aria-modal="true"` -- indicates the drawer is modal, restricting interaction to its contents
- `data-side={side}` -- data attribute for consumer CSS styling based on drawer position

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/dialog-modal/
