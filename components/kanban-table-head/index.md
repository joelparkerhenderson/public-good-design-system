# Kanban Table Head

A Kanban table head provides a header row for a Kanban board, containing column headings that label each workflow stage (e.g., "To Do", "In Progress", "Done"). It renders as a `<div>` with appropriate ARIA attributes and is designed to be used as a child of a KanbanTable component. The header establishes the visual and semantic structure for the columns below it.

## Implementation Notes

- Renders as a `<div>` for the Kanban board header area
- Contains column heading elements that label each workflow stage
- Consumer provides heading content through the children slot, typically a row of heading elements
- Spreads `...restProps` onto the `<div>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- column heading content for each workflow stage
- `...restProps`: any -- additional HTML attributes spread onto the `<div>` element

## Usage

```html
<KanbanTable label="Sprint board">
    <KanbanTableHead>
        <div>
            <h3>To Do</h3>
        </div>
        <div>
            <h3>In Progress</h3>
        </div>
        <div>
            <h3>Done</h3>
        </div>
    </KanbanTableHead>
    <KanbanTableBody>
        ...
    </KanbanTableBody>
</KanbanTable>
```

## Keyboard Interactions

None -- passive container for heading elements. Keyboard interaction depends on interactive elements within the header content provided by the consumer.

## ARIA

- No explicit ARIA roles required -- the headings within provide their own semantic structure
- Column headings should use appropriate heading levels (e.g., `<h3>`) for proper document outline

## References

- WAI-ARIA region role: https://www.w3.org/TR/wai-aria-1.2/#region
