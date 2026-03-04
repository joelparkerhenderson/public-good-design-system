# Context Menu

A context menu provides a list of actions relevant to the current context, typically triggered by a right-click or long-press. The menu appears near the pointer and offers contextual options such as cut, copy, paste, or custom actions.

This component manages menu visibility, keyboard navigation, and focus. When opened, focus moves to the first menu item automatically. Arrow keys navigate between items with wrapping, and Escape closes the menu. Consumers trigger opening externally (e.g., via a `contextmenu` event handler) and provide `role="menuitem"` children.

## Implementation Notes

- Renders a `<div>` with `role="menu"` and `aria-label`, conditionally shown via conditional rendering
- Supports two-way binding on the `open` prop
- reactive state tracks the menu element reference for focus management
- `$effect()` focuses the first `[role="menuitem"]` when the menu opens
- Keyboard handler navigates items with ArrowDown/ArrowUp (wrapping), Home/End, and Escape to close
- Spreads `restProps` onto the menu container

## Props

- `label`: string (required) -- accessible name for the context menu via `aria-label`
- `open`: boolean (default: false) -- whether the menu is visible; bindable for two-way control
- `children`: slot (required) -- menu item content (should include `role="menuitem"` elements)

## Usage

```html
<ContextMenu label="Actions" open={open}>
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

## ARIA

- `role="menu"` -- identifies the container as a menu widget
- `aria-label` -- provides an accessible name for the menu

## When to Use

- Use a ContextMenu to provide contextual actions triggered by right-click or long-press, such as cut, copy, paste, or custom actions relevant to the selected element.
- Use a ContextMenu when actions apply to a specific item and displaying them inline would clutter the interface.
- Avoid using a ContextMenu as the only way to access critical actions; ensure all actions are also available through visible controls.

## Headless

This headless ContextMenu component provides a `<div>` with `role="menu"` and `aria-label`, automatic focus management (first item receives focus on open), keyboard navigation with ArrowUp/ArrowDown wrapping, Home/End, and Escape to close. The consumer provides all visual styling including positioning near the pointer, background, borders, shadows, and item appearance.

## Advice

- **Designers**: Position the menu near the trigger point and ensure it does not overflow the viewport. Group related actions with visual separators.
- **Developers**: Trigger the menu by handling the `contextmenu` event on the target element and setting `open` to true. Use ContextMenuItem components as children with `role="menuitem"`.

## Composition

ContextMenu follows the Menu/MenuItem composition pattern. Use ContextMenu as the container with ContextMenuItem components as children. The ContextMenu manages focus and keyboard navigation, while each ContextMenuItem renders as a `role="menuitem"` element with `tabindex="-1"` for roving focus.

## References

- WAI-ARIA Menu Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/menu/
