# Task Bar

A task bar is a toolbar-style container for task-related action buttons, using the ARIA `toolbar` role with accessible labeling. It renders as a `<div>` with `role="toolbar"` to group related task actions together, making the container semantically meaningful to assistive technologies.

Task bars are commonly used to provide quick access to frequently performed actions such as "New", "Open", "Save", or other task-specific operations. The component works with TaskBarItem child components or plain buttons.

## Implementation Notes

- Renders as a `<div>` element with `role="toolbar"` to identify it as a toolbar widget
- Accessible name is set via `aria-label` from the required `label` prop
- Content is provided through the children slot, typically TaskBarItem components or buttons
- Does not implement arrow key navigation itself; consumers can add keyboard navigation as needed
- Passes through all additional HTML attributes via `...restProps`
- Uses `slot` for children content

## Props

- `label`: string (required) -- accessible name for the toolbar via aria-label
- `children`: slot (required) -- task bar item elements

## Usage

```html
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

## When to Use

- Use to group frequently performed task actions (e.g., "New", "Open", "Save") in a toolbar-style container for quick access.
- Use when related action buttons should be semantically grouped as a toolbar for assistive technologies.
- Avoid for navigation links; use a NavigationMenu or MenuBar instead.
- Consider a ToolBar when the actions are general-purpose editing tools rather than task-specific operations.

## Headless

This headless component renders a `<div>` with `role="toolbar"` and `aria-label` to identify it as a toolbar widget for assistive technologies. The consumer provides all child buttons, keyboard navigation (if arrow key support is desired), and visual styling including layout, spacing, and button appearance.


## Styles

The consumer provides all CSS styling. The component renders with a `.task-bar` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `task-bar`
- Verify role="toolbar"` -- identifies the container as a toolbar widget, grouping related controls
- Verify aria-label` -- provides the accessible name for the toolbar, set from the `label` prop
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Arrange buttons in a logical order of frequency or workflow. Use icon+label or icon-only buttons with tooltips for space efficiency.
- **Developers**: Place TaskBarButton components or plain buttons as children. Consider implementing arrow key navigation within the toolbar for full WAI-ARIA toolbar compliance.

## Composition

TaskBar uses the Bar/BarButton composition pattern. Place TaskBarButton components as children inside TaskBar. The TaskBar provides the `role="toolbar"` container with an accessible label, while each TaskBarButton provides an individual action button within the toolbar.

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
