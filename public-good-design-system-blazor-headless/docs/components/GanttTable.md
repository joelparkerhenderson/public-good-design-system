# GanttTable

An interactive Gantt table that displays project tasks and their timelines as a structured grid widget. Renders a `<table>` element with `role="grid"` and an accessible label. Supports an optional visible caption. Commonly used in project management tools and resource planning applications.

Compound component: use with GanttTableHead, GanttTableBody, GanttTableFoot, GanttTableRow, GanttTableData, and GanttTableCol.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Caption` | `string?` | `—` | The caption value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<GanttTable label="Project Alpha timeline">
  <GanttTableHead>
    <GanttTableRow>
      <th>Task</th><th>Week 1</th><th>Week 2</th><th>Week 3</th>
    </GanttTableRow>
  </GanttTableHead>
  <GanttTableBody>
    <GanttTableRow>
      <th>Design</th>
      <GanttTableData active>---</GanttTableData>
      <GanttTableData />
      <GanttTableData />
    </GanttTableRow>
    <GanttTableRow>
      <th>Development</th>
      <GanttTableData />
      <GanttTableData active>---</GanttTableData>
      <GanttTableData active>---</GanttTableData>
    </GanttTableRow>
  </GanttTableBody>
</GanttTable>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
