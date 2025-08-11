# ContextMenu

A context menu provides a list of actions relevant to the current context, typically triggered by a right-click or long-press. The menu appears near the pointer and offers contextual options such as cut, copy, paste, or custom actions.

This component manages menu visibility, keyboard navigation, and focus. When opened, focus moves to the first menu item automatically. Arrow keys navigate between items with wrapping, and Escape closes the menu. Consumers trigger opening externally (e.g., via a `contextmenu` event handler) and provide `role="menuitem"` children.

## Implementation Notes

- Renders a `<div>` with `role="menu"` and `aria-label`, conditionally shown via `{#if open}`
- Uses `$bindable(false)` for the `open` prop for two-way binding
- `private field` tracks the menu element reference for focus management
- `$effect()` focuses the first `[role="menuitem"]` when the menu opens
- Keyboard handler navigates items with ArrowDown/ArrowUp (wrapping), Home/End, and Escape to close
- Spreads `AdditionalAttributes` onto the menu container

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ContextMenu label="Actions" @bind-Open>
  <li role="menuitem" tabindex="-1">Cut</li>
  <li role="menuitem" tabindex="-1">Copy</li>
  <li role="menuitem" tabindex="-1">Paste</li>
</ContextMenu>
```


## Keyboard Interactions

- ArrowDown: Move focus to the next menu item (wraps to first)
- ArrowUp: Move focus to the previous menu item (wraps to last)
- Home: Move focus to the first menu item
- End: Move focus to the last menu item
- Escape: Close the menu

## ARIA Attributes

- `role="menu"` -- identifies the container as a menu widget
- `aria-label` -- provides an accessible name for the menu

## References

- WAI-ARIA Menu Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/menu/
