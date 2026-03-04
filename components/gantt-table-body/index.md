# Gantt Table Body

A Gantt table body is the main content section of a Gantt chart grid, wrapping the rows that represent individual tasks and their timeline data. Each row typically contains a task name and cells indicating the task's duration across time periods. It is designed to be used inside a GanttTable `<table>` structure.

The component renders a `<tbody>` element and passes through its children, which are expected to be GanttTableRow or `<tr>` elements containing task and timeline cells.

## Implementation Notes

- Renders as a `<tbody>` element for the body section of a Gantt chart grid
- Children should be task rows, each with a task-name cell and time-period cells
- Designed to be used inside a GanttTable `<table>` structure
- Spreads `restProps` onto the `<tbody>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- task rows representing items and their timeline data
- `...restProps`: Any additional HTML attributes passed to the `<tbody>` element

## Usage

```html
<GanttTable label="Project Alpha timeline">
  <GanttTableHead>...</GanttTableHead>
  <GanttTableBody>
    <tr><th>Design</th><td>---</td><td></td><td></td><td></td></tr>
    <tr><th>Development</th><td></td><td>---</td><td>---</td><td></td></tr>
    <tr><th>Testing</th><td></td><td></td><td></td><td>---</td></tr>
  </GanttTableBody>
</GanttTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent GanttTable grid.

## ARIA

- Implicit `rowgroup` role from the `<tbody>` element -- groups the body rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
