# Gantt Table Head

A Gantt table head is the header section of a Gantt chart grid, wrapping one or more rows that label the columns of the chart. Typically contains a row with a task-name column header and time-period column headers (e.g., weeks, months, sprints). It is designed to be used inside a GanttTable `<table>` structure.

The component renders a `<thead>` element and passes through its children, which are expected to be GanttTableRow or `<tr>` elements containing `<th>` header cells.

## Implementation Notes

- Renders as a `<thead>` element for the header section of a Gantt chart grid
- Children should be one or more rows with `<th>` cells labeling the task column and time-period columns
- Designed to be used inside a GanttTable `<table>` structure
- Spreads `restProps` onto the `<thead>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- header rows containing column labels for tasks and time periods
- `...restProps`: Any additional HTML attributes passed to the `<thead>` element

## Usage

```html
<GanttTable label="Project Alpha timeline">
  <GanttTableHead>
    <tr><th>Task</th><th>Week 1</th><th>Week 2</th><th>Week 3</th><th>Week 4</th></tr>
  </GanttTableHead>
  <GanttTableBody>...</GanttTableBody>
</GanttTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent GanttTable grid.

## ARIA

- Implicit `rowgroup` role from the `<thead>` element -- groups the header rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
