# TaskBar

A task bar is a toolbar-style container for task-related action buttons, using the ARIA `toolbar` role with accessible labeling. It renders as a `<div>` with `role="toolbar"` to group related task actions together, making the container semantically meaningful to assistive technologies.

Task bars are commonly used to provide quick access to frequently performed actions such as "New", "Open", "Save", or other task-specific operations. The component works with TaskBarItem child components or plain buttons.

## Implementation Notes

- Renders as a `<div>` element with `role="toolbar"` to identify it as a toolbar widget
- Accessible name is set via `aria-label` from the required `label` prop
- Content is provided through the children snippet, typically TaskBarItem components or buttons
- Does not implement arrow key navigation itself; consumers can add keyboard navigation as needed
- Passes through all additional HTML attributes via `...restProps`
- Uses Svelte 5 `Snippet` for children content

## Props

- `label`: string (required) -- accessible name for the toolbar via aria-label
- `children`: Snippet (required) -- task bar item elements

## Usage

```svelte
<TaskBar label="Tasks">
  <button>New</button>
  <button>Open</button>
</TaskBar>
```

## Keyboard Interactions

- Tab: Focus moves to the first focusable item within the toolbar (native browser behavior)

## ARIA

- `role="toolbar"` -- identifies the container as a toolbar widget, grouping related controls
- `aria-label` -- provides the accessible name for the toolbar, set from the `label` prop

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
