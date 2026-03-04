# Calendar Table Row

A calendar table row represents a single row within a calendar grid, typically corresponding to one week. It wraps day cells or header cells in a horizontal sequence. It is designed to be used inside a CalendarTableHead, CalendarTableBody, or CalendarTableFoot section.

The component renders a `<tr>` element and passes through its children, which are expected to be `<td>`, `<th>`, or CalendarTableCell elements.

## Implementation Notes

- Renders as a `<tr>` element for one row in a calendar grid
- Children should be day cells (`<td>` or CalendarTableCell) or header cells (`<th>`)
- Designed to be used inside CalendarTableHead, CalendarTableBody, or CalendarTableFoot
- Spreads `restProps` onto the `<tr>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- cells for this row, typically day numbers or day-of-week labels
- `...restProps`: Any additional HTML attributes passed to the `<tr>` element

## Usage

```html
<CalendarTableBody>
  <CalendarTableRow>
    <td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td>
  </CalendarTableRow>
  <CalendarTableRow>
    <td>8</td><td>9</td><td>10</td><td>11</td><td>12</td><td>13</td><td>14</td>
  </CalendarTableRow>
</CalendarTableBody>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent CalendarTable grid.

## ARIA

- Implicit `row` role from the `<tr>` element -- identifies a row of cells within the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
