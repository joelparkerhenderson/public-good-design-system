# Calendar Table Head

A calendar table head is the header section of a calendar grid, wrapping one or more rows that label the columns of the calendar. Typically contains a single row with day-of-week abbreviations (e.g., Sun, Mon, Tue). It is designed to be used inside a CalendarTable `<table>` structure.

The component renders a `<thead>` element and passes through its children, which are expected to be CalendarTableRow or `<tr>` elements containing `<th>` header cells.

## Implementation Notes

- Renders as a `<thead>` element for the header section of a calendar grid
- Children should be one or more rows with `<th>` cells labeling calendar columns (e.g., days of the week)
- Designed to be used inside a CalendarTable `<table>` structure
- Spreads `restProps` onto the `<thead>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- header rows, typically containing day-of-week labels
- `...restProps`: Any additional HTML attributes passed to the `<thead>` element

## Usage

```html
<CalendarTable label="January 2025">
  <CalendarTableHead>
    <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>
  </CalendarTableHead>
  <CalendarTableBody>...</CalendarTableBody>
</CalendarTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent CalendarTable grid.

## ARIA

- Implicit `rowgroup` role from the `<thead>` element -- groups the header rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
