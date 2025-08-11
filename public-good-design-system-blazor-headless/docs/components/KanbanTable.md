# KanbanTable

A Kanban table organizes work items into columns representing different workflow stages such as "To Do", "In Progress", and "Done". Renders as a `<table>` with `role="grid"` and an accessible label. Supports an optional visible caption. Commonly used in project management tools, agile development platforms, and task tracking applications.

Compound component: use with KanbanTableHead, KanbanTableBody, KanbanTableFoot, KanbanTableRow, KanbanTableData, and KanbanTableCol.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Caption` | `string?` | `—` | The caption value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTable label="Sprint 5 board">
  <KanbanTableHead>
    <KanbanTableRow><th>To Do</th><th>In Progress</th><th>Done</th></KanbanTableRow>
  </KanbanTableHead>
  <KanbanTableBody>
    <KanbanTableRow>
      <KanbanTableData>Task A</KanbanTableData>
      <KanbanTableData>Task B</KanbanTableData>
      <KanbanTableData>Task C</KanbanTableData>
    </KanbanTableRow>
  </KanbanTableBody>
</KanbanTable>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
