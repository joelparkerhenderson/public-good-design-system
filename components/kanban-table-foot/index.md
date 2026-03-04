# Kanban Table Foot

A Kanban table foot provides an optional footer area for a Kanban board, typically used for board-level summary information or actions such as "Add column", item counts per column, or aggregate status indicators. It renders as a `<div>` and is designed to be used as a child of a KanbanTable component, appearing below the KanbanTableBody.

## Implementation Notes

- Renders as a `<div>` for the Kanban board footer area
- Optional component -- only include when the board needs footer-level actions or summaries
- Consumer provides footer content through the children slot
- Spreads `...restProps` onto the `<div>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- footer content such as action buttons, item counts, or summary information
- `...restProps`: any -- additional HTML attributes spread onto the `<div>` element

## Usage

```html
<KanbanTable label="Sprint board">
    <KanbanTableHead>
        ...
    </KanbanTableHead>
    <KanbanTableBody>
        ...
    </KanbanTableBody>
    <KanbanTableFoot>
        <button>Add column</button>
        <span>12 items total</span>
    </KanbanTableFoot>
</KanbanTable>
```

## Keyboard Interactions

None -- passive container. Keyboard interaction depends on interactive elements within the footer content provided by the consumer.

## ARIA

- No explicit ARIA roles required on the footer container itself
- Interactive elements within the footer (e.g., buttons) provide their own semantics

## References

- WAI-ARIA region role: https://www.w3.org/TR/wai-aria-1.2/#region
