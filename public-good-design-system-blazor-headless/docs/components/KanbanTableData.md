# KanbanTableData

A Kanban table data cell is a single cell within a KanbanTableRow, rendered as a `<td>` with `role="gridcell"`. Represents a task card or content area within a workflow column. Supports an active state with `aria-selected` and roving tabindex for keyboard navigation.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Active` | `bool` | `—` | The active value |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment?` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTableRow>
  <KanbanTableData active label="Fix login bug">Fix login bug</KanbanTableData>
  <KanbanTableData />
  <KanbanTableData />
</KanbanTableRow>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
