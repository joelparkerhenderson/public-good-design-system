# Task Bar Item

A task bar item is a single button within a task bar, rendered as a native `<button>` element for proper keyboard and screen reader support. It is designed to be placed inside a TaskBar container that manages layout and grouping.

The component uses `<button type="button">` to avoid unintended form submissions and supports the `disabled` attribute for disabling interaction. Content is provided through the children slot, allowing full flexibility in button content.

## Implementation Notes

- Renders as a `<button type="button">` element for native button semantics
- Supports a `disabled` prop to disable the button
- Content is provided through child elements
- Passes through all additional HTML attributes via `...restProps`
- Designed to be placed inside a TaskBar container

## Props

- `disabled`: boolean (default: false) -- whether the button is disabled
- `children`: slot (required) -- button content
- `...restProps`: Any additional HTML attributes passed to the `<button>` element

## Usage

```html
<TaskBarItem>New Task</TaskBarItem>
```

## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button (browser default)
- Button is skipped in tab order when `disabled` is true

## ARIA

- Implicit `button` role from the `<button>` element
- `disabled` attribute communicates disabled state to assistive technology

## When to Use

- Use inside a TaskBar to represent a single action button such as "New", "Open", "Save", or other task-specific operations.
- Use when a button should be grouped within a toolbar context for proper assistive technology announcements.
- Avoid using outside a TaskBar; use a standalone Button component for general-purpose actions.

## Headless

This headless component renders a `<button type="button">` element with `disabled` support and a children slot for content. It provides native button semantics without accidental form submission. The consumer provides all visual styling including colors, sizing, icons, and hover/focus states.

## Advice

- **Designers**: Use consistent button sizing within the task bar. Consider icon-only buttons with tooltips when horizontal space is limited.
- **Developers**: Use `type="button"` (already set) to prevent accidental form submissions. Handle click events via `onclick` in `restProps` for action behavior.

## Composition

TaskBarButton is designed to be used as a child of TaskBar. The TaskBar provides the `role="toolbar"` container, and each TaskBarButton provides an individual action button within it.
