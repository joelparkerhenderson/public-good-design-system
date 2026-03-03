# KanbanTableCol

A Kanban table column definition, rendered as a `<col>` element. Used inside a `<colgroup>` to define column properties for each workflow stage.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Span` | `string` | `—` | The span value |

## Usage


```razor
<KanbanTable label="Board">
  <colgroup>
    <KanbanTableCol span=@1 />
    <KanbanTableCol span=@1 />
    <KanbanTableCol span=@1 />
  </colgroup>
  ...
</KanbanTable>
```



## References

- HTML col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
