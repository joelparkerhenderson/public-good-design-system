# MenuBarItem

A menu bar item is a single interactive item within a menu bar, using the ARIA menuitem role for keyboard navigation and screen reader support. It renders as a `<div>` with `role="menuitem"` and is designed to be placed inside a MenuBar container with `role="menubar"`.

Focus management is delegated to the parent MenuBar, which uses roving tabindex to move focus between items with arrow keys. The item itself uses `tabindex="-1"` so it is not reachable via Tab but can receive focus programmatically.

## Implementation Notes

- Renders as a `<div>` with `role="menuitem"` for ARIA menubar semantics
- Uses `tabindex="-1"` so focus is managed programmatically by the parent MenuBar
- Content is provided through the Svelte 5 `children` Snippet
- Passes through all additional HTML attributes via `...restProps`
- Designed to be placed inside a MenuBar container with `role="menubar"`

## Props

- `children`: Snippet (required) -- content of the menu bar item
- `...restProps`: Any additional HTML attributes passed to the `<div>` element

## Usage

```svelte
<MenuBarItem>File</MenuBarItem>
```

## Keyboard Interactions

- Arrow keys: Focus movement is managed by the parent MenuBar
- Enter / Space: Activate the menu item (consumer-provided handler)
- `tabindex="-1"` enables programmatic focus from parent keyboard navigation

## ARIA

- `role="menuitem"` -- identifies this as an item within a menubar
- `tabindex="-1"` -- removed from tab order; focus managed by parent MenuBar

## References

- WAI-ARIA Menu Bar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/menubar/
