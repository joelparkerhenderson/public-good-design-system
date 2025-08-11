# GanttTableFoot

The footer section of a GanttTable, rendered as a `<tfoot>` element. Contains GanttTableRow elements with summary or aggregate data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<GanttTableFoot>
  <GanttTableRow>
    <GanttTableData>Total: 12 tasks</GanttTableData>
  </GanttTableRow>
</GanttTableFoot>
```



## References

- HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
