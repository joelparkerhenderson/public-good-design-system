# KanbanTableBody

The body section of a KanbanTable, rendered as a `<tbody>` element. Contains KanbanTableRow elements with task data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTableBody>
  <KanbanTableRow>
    <KanbanTableData>Task A</KanbanTableData>
    <KanbanTableData>Task B</KanbanTableData>
  </KanbanTableRow>
</KanbanTableBody>
```



## References

- HTML tbody element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody
