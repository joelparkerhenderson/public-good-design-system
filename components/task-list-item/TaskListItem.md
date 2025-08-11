# TaskListItem

A single item within a TaskList. Renders a semantic `<li>` element representing one task, action, or to-do. The `completed` prop controls a `data-completed` attribute for consumer styling, communicating task state to visual presentation.

This component is designed to be placed inside a TaskList `<ul>`. The consumer provides the task content through the children snippet, and optionally marks items as completed for progress tracking.

## Implementation Notes

- Renders as a semantic `<li>` element for use within a TaskList `<ul>`
- Sets `data-completed` attribute (`"true"` or `"false"`) for consumer CSS hooks
- Defaults `completed` to `false` when not specified
- All task content is provided through the children snippet
- Spreads `...restProps` onto the `<li>` element for consumer customization

## Props

- `completed`: boolean (default: `false`) -- whether the task is completed
- `children`: Snippet (required) -- task content
- `...restProps`: Any additional HTML attributes spread onto the `<li>`

## Usage

```svelte
<TaskList label="Today's tasks">
  <TaskListItem completed={true}>Review pull requests</TaskListItem>
  <TaskListItem>Update documentation</TaskListItem>
  <TaskListItem>Deploy to staging</TaskListItem>
</TaskList>
```

With checkboxes for interactive tasks:

```svelte
<TaskList label="Onboarding checklist">
  <TaskListItem completed={done1}>
    <label><input type="checkbox" bind:checked={done1} /> Create account</label>
  </TaskListItem>
  <TaskListItem completed={done2}>
    <label><input type="checkbox" bind:checked={done2} /> Set up profile</label>
  </TaskListItem>
</TaskList>
```

Consumer CSS example using `data-completed`:

```css
[data-completed="true"] { text-decoration: line-through; opacity: 0.6; }
[data-completed="false"] { font-weight: normal; }
```

## Keyboard Interactions

- None directly -- standard list item with no interactive behavior
- If the item contains interactive elements (checkboxes, links), they handle their own keyboard behavior

## ARIA

- Semantic `<li>` provides implicit `listitem` role
- `data-completed` communicates task state for consumer styling hooks

## References

- MDN li element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
