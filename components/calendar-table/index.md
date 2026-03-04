# Calendar Table

A calendar board is a component that presents dates in a structured grid layout, typically organized by weeks and days, allowing users to view and interact with calendar data at a glance. Commonly used in scheduling applications, event planners, and dashboard interfaces, the calendar board renders dates as cells within a table grid, making it easy to scan across days, weeks, or months.

This headless component renders a `<table>` element with `role="grid"` and an accessible label. The consumer provides the table rows and cells as children, along with any header rows for day-of-week labels.

## Implementation Notes

- Renders a `<table>` element with `role="grid"` for structured calendar grid semantics
- Consumer provides `<tr>` rows with `<td>` or `<th>` cells as children
- The `label` prop should describe the calendar period (e.g., "January 2025")
- Accepts `...restProps` for forwarding additional attributes to the table element
- No internal state -- purely a structural wrapper

## Props

- `label`: string (required) -- accessible name describing the calendar period (e.g., month and year), applied via `aria-label`
- `children`: slot (required) -- table rows and cells representing the calendar grid

## Usage

```html
<CalendarTable label="January 2025">
    <thead>
        <tr><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></tr>
    </thead>
    <tbody>
        <tr><td>1</td><td>2</td><td>3</td><td>4</td><td>5</td><td>6</td><td>7</td></tr>
    </tbody>
</CalendarTable>
```

## Keyboard Interactions

None built-in -- the consumer should implement grid keyboard navigation on cells as needed (arrow keys for cell-to-cell movement, Enter/Space for selection).

## ARIA

- `role="grid"` -- identifies the table as an interactive grid widget
- `aria-label={label}` -- provides an accessible name describing the calendar period

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
