# KanbanTableRow

A Kanban table row is a single row within a KanbanTable grid. Renders as a `<tr>` containing KanbanTableData cells for each workflow column.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTableRow>
  <KanbanTableData>Task A</KanbanTableData>
  <KanbanTableData>Task B</KanbanTableData>
</KanbanTableRow>
```



## ARIA Attributes

- `<tr>` has implicit `role="row"` (no explicit role needed)

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
