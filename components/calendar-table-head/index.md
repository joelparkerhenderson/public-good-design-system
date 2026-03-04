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

## When to Use

- Use as the header section of a CalendarTable to display day-of-week column labels (e.g., Sun, Mon, Tue).
- Use when you need to provide semantic column headers for the calendar grid.
- Avoid using outside of a CalendarTable parent -- the parent provides the required `<table>` and `role="grid"` structure.

## Headless

This component provides a semantic `<thead>` element with implicit `rowgroup` role and zero visual styling. The consumer is responsible for all CSS including header cell typography, alignment, background color, bottom borders, and any abbreviation formatting for day names.

## Advice

- **Designers**: Keep day-of-week labels short (2-3 characters) to fit within cell widths. Use a visually distinct style (bold, different background) to separate the header from body rows.
- **Developers**: Use `<th>` elements inside the header row for proper column header semantics. Consider using `<abbr>` within `<th>` for abbreviated day names with full title attributes.

## Composition

CalendarTableHead is part of the CalendarTable composition pattern:

- **CalendarTable** -- outer `<table>` with `role="grid"`.
- **CalendarTableHead** -- `<thead>` for day-of-week column headers.
- **CalendarTableBody** -- `<tbody>` for day rows.
- **CalendarTableRow** -- `<tr>` within any section.

```html
<CalendarTable label="January 2025">
  <CalendarTableHead>
    <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>
  </CalendarTableHead>
  <CalendarTableBody>...</CalendarTableBody>
</CalendarTable>
```

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
