# GanttTableHead

The header section of a GanttTable, rendered as a `<thead>` element. Contains GanttTableRow elements with column headers for task names, dates, durations, or other Gantt chart metadata.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<GanttTableHead>
  <GanttTableRow><th>Task</th><th>Start</th><th>End</th></GanttTableRow>
</GanttTableHead>
```



## References

- HTML thead element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/thead
