# KanbanTableFoot

The footer section of a KanbanTable, rendered as a `<tfoot>` element. Contains KanbanTableRow elements with summary or aggregate data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<KanbanTableFoot>
  <KanbanTableRow>
    <KanbanTableData>Total: 3</KanbanTableData>
    <KanbanTableData>Total: 5</KanbanTableData>
  </KanbanTableRow>
</KanbanTableFoot>
```



## References

- HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
