# Task List

A task list is a UI/UX component that organizes and displays a series of tasks,
actions, or to-dos for users to complete. It is typically presented as a
checklist, where each task can be marked as completed or remain pending. Task
lists are commonly used in project management tools, to-do apps, or onboarding
processes to guide users through a sequence of actions. They help improve
productivity by breaking down complex workflows into manageable steps, offering
clear progress tracking. Effective task list design includes features like task
prioritization, due dates, and visual indicators (such as checkboxes or progress
bars) to enhance user clarity and motivation.

This component renders as an unordered list (`<ul>`) with `role="list"` and an
accessible label. The explicit `role="list"` ensures screen readers announce the
list semantics even when CSS removes default list styling. The consumer provides
task items as `<li>` children through the children slot.

## Implementation Notes

- Renders as `<ul role="list" aria-label={label}>` for task list semantics
- Explicit `role="list"` ensures list semantics when CSS removes default styling
- All task content provided through children slot (should be `<li>` elements)
- Consumers can use checkboxes within `<li>` for completable tasks
- No hardcoded strings; all text content comes through props and children

## Props

- `label`: string (required) -- accessible label via aria-label
- `children`: slot -- task items (should be `<li>` elements)
- `...restProps`: Any additional HTML attributes spread onto the `<ul>`

## Usage

```html
<TaskList label="Today's tasks">
  <li>Review pull requests</li>
  <li>Update documentation</li>
  <li>Deploy to staging</li>
</TaskList>
```

With checkboxes for completable tasks:

```html
<TaskList label="Onboarding checklist">
  <li>
    <label>
      <input type="checkbox" /> Create account
    </label>
  </li>
  <li>
    <label>
      <input type="checkbox" /> Set up profile
    </label>
  </li>
  <li>
    <label>
      <input type="checkbox" /> Complete tutorial
    </label>
  </li>
</TaskList>
```

## Keyboard Interactions

- None directly -- standard list navigation by screen readers
- Tab moves focus between interactive elements (checkboxes, links) within task items

## ARIA

- `role="list"` explicitly marks as a list
- `aria-label` provides accessible name for the list
- Screen readers announce the list with its label and item count

## When to Use

- Use to display a series of tasks, actions, or to-dos that users can track and complete, such as project checklists, onboarding steps, or daily task lists.
- Use when tasks benefit from being presented in a scannable list with optional completion tracking.
- Avoid for ordered step-by-step instructions where sequence matters; consider a Timeline or numbered list instead.
- Consider a CheckList when every item is a simple checkbox without additional task metadata.

## Headless

This headless component renders a `<ul>` with explicit `role="list"` and `aria-label` to ensure list semantics are preserved even when CSS removes default styling. The consumer provides all visual styling including layout, spacing, completion indicators, and any interactive elements within list items.

## Advice

- **Designers**: Include clear completion indicators such as checkboxes or strikethrough text. Use visual hierarchy to distinguish completed tasks from pending ones.
- **Developers**: Use TaskListItem children for structured task items with completion state. The explicit `role="list"` ensures screen readers announce item counts even with `list-style: none` CSS.

## Composition

TaskList uses the List/ListItem composition pattern. Place TaskListItem components as children inside TaskList. The TaskList provides the outer `<ul>` container with accessible labeling, while each TaskListItem provides an individual `<li>` with completion state tracking via `data-completed`.

## References

- WAI-ARIA list role: https://www.w3.org/TR/wai-aria-1.2/#list
