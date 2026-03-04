# Kanban Table Data

A Kanban board item is a component that represents a single work item or task card within a Kanban board column. Each item typically displays summary information about a task, such as its title, assignee, priority, or due date, and serves as the unit that moves between workflow stages.

This component is designed to be used as a child element within a Kanban column that has `role="list"`. It renders as a `<div>` with `role="listitem"` to convey its semantic position within the list, supports an optional accessible label for screen reader identification, and allows consumers to render any content inside it through the children snippet.

## Implementation Notes

- Renders as a `<div>` with `role="listitem"` for proper list semantics within a parent `role="list"` container
- Designed to be used inside a Kanban column; the parent column provides the `role="list"` context
- Optional `label` prop sets `aria-label` for screen reader identification of the card
- All card content is provided through the `children` snippet
- Uses Svelte 5 `$props()` for prop destructuring with rest props spread
- No drag-and-drop behavior built in; consumers implement interaction as needed

## Props

- `label`: string (optional) -- accessible label for the card via `aria-label`
- `children`: Snippet (required) -- card content (title, assignee, metadata, etc.)
- `...restProps`: any -- additional HTML attributes spread onto the `<div>` element

## Usage

```svelte
<KanbanTableData label="Fix login bug">
    <h3>Fix login bug</h3>
    <p>Assigned to Alice</p>
</KanbanTableData>
```

```svelte
<KanbanTableData label={task.title}>
    <span>{task.title}</span>
    <span>{task.priority}</span>
</KanbanTableData>
```

## Keyboard Interactions

- None directly -- keyboard interaction depends on interactive elements within the card content provided by the consumer

## ARIA

- `role="listitem"` -- identifies this as an item within a list container (the parent Kanban column with `role="list"`)
- `aria-label` -- optional accessible name for the card, set from the `label` prop, allowing screen readers to identify individual cards

## References

- WAI-ARIA Listitem Role: https://www.w3.org/TR/wai-aria-1.2/#listitem
