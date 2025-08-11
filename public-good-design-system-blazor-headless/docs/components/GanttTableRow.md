# GanttTableRow

A single row within a GanttTable grid. Renders as a `<tr>` containing GanttTableData cells for each time period and task header cells. Used inside GanttTableHead, GanttTableBody, or GanttTableFoot.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<!-- Task row with active time periods -->
<GanttTableRow>
  <th>Development</th>
  <GanttTableData />
  <GanttTableData active>---</GanttTableData>
  <GanttTableData active>---</GanttTableData>
</GanttTableRow>

<!-- Header row -->
<GanttTableRow>
  <th>Task</th><th>Week 1</th><th>Week 2</th><th>Week 3</th>
</GanttTableRow>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
