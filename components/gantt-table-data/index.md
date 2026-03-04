# Gantt Table Data

A Gantt table data cell represents a single time period cell within a task row of a Gantt chart. It renders as a `<td>` element and is designed to be placed inside a GanttTableRow within a GanttTableBody. Each cell corresponds to one time period (e.g., a day, week, or sprint) for a particular task, and the consumer provides the cell content, such as a bar segment, milestone marker, or empty space.

## Implementation Notes

- Renders as a `<td>` element for use inside a GanttTableRow within a GanttTable grid
- Content is provided through the children slot, typically bar segments, milestone markers, or progress indicators
- Spreads `...restProps` onto the `<td>` element for consumer customization
- No internal state -- purely a structural wrapper for cell content

## Props

- `children`: slot (required) -- cell content such as bar segments, milestone markers, or text
- `...restProps`: any -- additional HTML attributes spread onto the `<td>` element

## Usage

```html
<GanttTableBody>
    <GanttTableRow>
        <th>Design</th>
        <GanttTableData class="bar">---</GanttTableData>
        <GanttTableData></GanttTableData>
        <GanttTableData></GanttTableData>
    </GanttTableRow>
    <GanttTableRow>
        <th>Development</th>
        <GanttTableData></GanttTableData>
        <GanttTableData class="bar">---</GanttTableData>
        <GanttTableData class="bar">---</GanttTableData>
    </GanttTableRow>
</GanttTableBody>
```

## Keyboard Interactions

None built-in -- the consumer should implement grid keyboard navigation on cells as needed (arrow keys for cell-to-cell movement within the grid).

## ARIA

- Implicit `gridcell` role from the `<td>` element when inside a `role="grid"` table
- Consumer may add `aria-label` or `aria-describedby` for cells with visual-only content (e.g., bar segments)

## When to Use

- Use inside a GanttTableRow to represent a single time period cell containing a bar segment, milestone marker, or empty space.
- Avoid using outside of a GanttTableRow within a GanttTable structure.

## Headless

This headless component provides a `<td>` element with implicit `gridcell` role when inside a `role="grid"` table. The consumer provides all visual styling including bar rendering, milestone markers, progress indicators, and background colors.

## Advice

- **Designers**: Use color-coded bar segments to represent task progress. Add milestone markers (e.g., diamonds) for key dates.
- **Developers**: Add `aria-label` to cells with visual-only content (e.g., bar segments) so screen readers can announce the cell meaning.

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
- WAI-ARIA gridcell role: https://www.w3.org/TR/wai-aria-1.2/#gridcell
