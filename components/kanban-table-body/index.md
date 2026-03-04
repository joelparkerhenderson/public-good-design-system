# Kanban Table Body

A Kanban table body provides the main content area of a Kanban board, containing the columns and cards that represent work items at various workflow stages. It renders as a `<div>` and is designed to be used as a child of a KanbanTable component. The body area holds the column containers with their respective card items.

## Implementation Notes

- Renders as a `<div>` for the main Kanban board content area
- Consumer provides column containers and card items through the children slot
- Each column within the body typically uses `role="list"` with KanbanTableData items as `role="listitem"` children
- Spreads `...restProps` onto the `<div>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- column containers with card content
- `...restProps`: any -- additional HTML attributes spread onto the `<div>` element

## Usage

```html
<KanbanTable label="Sprint board">
    <KanbanTableHead>
        ...
    </KanbanTableHead>
    <KanbanTableBody>
        <div role="list" aria-label="To Do">
            <KanbanTableData label="Fix login bug">
                <h4>Fix login bug</h4>
                <p>Assigned to Alice</p>
            </KanbanTableData>
        </div>
        <div role="list" aria-label="In Progress">
            <KanbanTableData label="Add dashboard">
                <h4>Add dashboard</h4>
                <p>Assigned to Bob</p>
            </KanbanTableData>
        </div>
        <div role="list" aria-label="Done">
            <KanbanTableData label="Setup CI/CD">
                <h4>Setup CI/CD</h4>
            </KanbanTableData>
        </div>
    </KanbanTableBody>
</KanbanTable>
```

## Keyboard Interactions

None -- passive container. Keyboard interaction depends on interactive elements within the card content provided by the consumer, such as drag-and-drop controls or card action buttons.

## ARIA

- No explicit ARIA roles required on the body container itself
- Column containers within should use `role="list"` with `aria-label` to identify each workflow stage
- Card items within columns should use `role="listitem"` (provided by KanbanTableData)

## References

- WAI-ARIA Listbox Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/listbox/
- WAI-ARIA region role: https://www.w3.org/TR/wai-aria-1.2/#region
