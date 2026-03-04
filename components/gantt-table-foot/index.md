# Gantt Table Foot

A Gantt table foot is the footer section of a Gantt chart grid, wrapping one or more rows that provide summary information such as milestone markers, totals, or project-level notes. It is designed to be used inside a GanttTable `<table>` structure.

The component renders a `<tfoot>` element and passes through its children, which are expected to be GanttTableRow or `<tr>` elements.

## Implementation Notes

- Renders as a `<tfoot>` element for the footer section of a Gantt chart grid
- Children should be one or more rows providing summary, milestone, or aggregate information
- Designed to be used inside a GanttTable `<table>` structure
- Spreads `restProps` onto the `<tfoot>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- footer rows with summary or milestone content
- `...restProps`: Any additional HTML attributes passed to the `<tfoot>` element

## Usage

```html
<GanttTable label="Project Alpha timeline">
  <GanttTableHead>...</GanttTableHead>
  <GanttTableBody>...</GanttTableBody>
  <GanttTableFoot>
    <tr><th>Milestone</th><td></td><td></td><td></td><td>Launch</td></tr>
  </GanttTableFoot>
</GanttTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent GanttTable grid.

## ARIA

- Implicit `rowgroup` role from the `<tfoot>` element -- groups the footer rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
