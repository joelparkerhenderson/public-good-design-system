# KanbanTableHead

The header section of a KanbanTable, rendered as a `<thead>` element. Contains KanbanTableRow elements with column headers for workflow stages.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTableHead>
  <KanbanTableRow><th>To Do</th><th>In Progress</th><th>Done</th></KanbanTableRow>
</KanbanTableHead>
```



## References

- HTML thead element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/thead
