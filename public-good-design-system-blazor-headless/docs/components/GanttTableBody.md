# GanttTableBody

The body section of a GanttTable, rendered as a `<tbody>` element. Contains GanttTableRow elements with task data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<GanttTableBody>
  <GanttTableRow>
    <GanttTableData>Design</GanttTableData>
    <GanttTableData>Jan 1</GanttTableData>
  </GanttTableRow>
</GanttTableBody>
```



## References

- HTML tbody element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody
