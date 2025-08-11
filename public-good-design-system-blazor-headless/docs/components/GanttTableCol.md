# GanttTableCol

A column definition within a GanttTable, rendered as a `<col>` element. Used inside a `<colgroup>` to define column properties such as span. Useful for styling entire columns of the Gantt grid (e.g. weekends, milestones, or specific time periods).

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Span` | `string` | `—` | The span value |

## Usage


```razor
<GanttTable label="Project timeline">
  <colgroup>
    <GanttTableCol />
    <GanttTableCol span=@5 />
    <GanttTableCol />
  </colgroup>
  ...
</GanttTable>
```



## References

- HTML col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
