# Calendar Table Body

A calendar table body is the main content section of a calendar grid, wrapping the rows that contain the day cells. It groups the data rows of the calendar, where each row represents a week and each cell represents a day. It is designed to be used inside a CalendarTable `<table>` structure.

The component renders a `<tbody>` element and passes through its children, which are expected to be CalendarTableRow or `<tr>` elements containing day cells.

## Implementation Notes

- Renders as a `<tbody>` element for the body section of a calendar grid
- Children should be rows of day cells, typically one row per week
- Designed to be used inside a CalendarTable `<table>` structure
- Spreads `restProps` onto the `<tbody>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- rows of day cells representing weeks in the calendar
- `...restProps`: Any additional HTML attributes passed to the `<tbody>` element

## Usage

```html
<CalendarTable label="January 2025">
  <CalendarTableHead>...</CalendarTableHead>
  <CalendarTableBody>
    <tr><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td></tr>
    <tr><td>8</td><td>9</td><td>10</td><td>11</td><td>12</td><td>13</td><td>14</td></tr>
  </CalendarTableBody>
</CalendarTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent CalendarTable grid.

## ARIA

- Implicit `rowgroup` role from the `<tbody>` element -- groups the body rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
