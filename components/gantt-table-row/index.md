# Gantt Table Row

A Gantt table row represents a single row within a Gantt chart grid, typically corresponding to one task or milestone. It wraps a task-name cell and time-period cells in a horizontal sequence. It is designed to be used inside a GanttTableHead, GanttTableBody, or GanttTableFoot section.

The component renders a `<tr>` element and passes through its children, which are expected to be `<td>`, `<th>`, or GanttTableData elements.

## Implementation Notes

- Renders as a `<tr>` element for one row in a Gantt chart grid
- Children should be a task-name header cell (`<th>`) followed by time-period data cells (`<td>` or GanttTableData)
- Designed to be used inside GanttTableHead, GanttTableBody, or GanttTableFoot
- Spreads `restProps` onto the `<tr>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- cells for this row, typically a task name and time-period indicators
- `...restProps`: Any additional HTML attributes passed to the `<tr>` element

## Usage

```html
<GanttTableBody>
  <GanttTableRow>
    <th>Design</th><td>---</td><td></td><td></td><td></td>
  </GanttTableRow>
  <GanttTableRow>
    <th>Development</th><td></td><td>---</td><td>---</td><td></td>
  </GanttTableRow>
</GanttTableBody>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent GanttTable grid.

## ARIA

- Implicit `row` role from the `<tr>` element -- identifies a row of cells within the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
