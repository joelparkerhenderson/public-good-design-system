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

## When to Use

- Use for each row within a CalendarTable section (head, body, or foot), where each row typically represents one week.
- Use when you need a `<tr>` container for day cells or header cells in the calendar grid.
- Avoid using outside of a CalendarTable structure -- the parent sections provide required grouping semantics.

## Headless

This component provides a semantic `<tr>` element with implicit `row` role and zero visual styling. The consumer is responsible for all CSS including row height, cell alignment, borders between rows, and any alternate-row shading.

## Advice

- **Designers**: Maintain consistent row heights across all weeks. Use subtle borders or spacing between rows to aid scanning.
- **Developers**: Each row in the body should contain exactly 7 cells for a standard weekly view. Use CalendarTableCell for day cells and `<th>` for header cells.

## Composition

CalendarTableRow is part of the CalendarTable composition pattern:

- **CalendarTable** -- outer `<table>` with `role="grid"`.
- **CalendarTableHead/Body/Foot** -- section groupings.
- **CalendarTableRow** -- `<tr>` representing one week or header row.
- **CalendarTableCell** -- `<td>` representing one day.

```html
<CalendarTableBody>
  <CalendarTableRow>
    <CalendarTableCell>1</CalendarTableCell>
    <CalendarTableCell>2</CalendarTableCell>
    <CalendarTableCell>3</CalendarTableCell>
  </CalendarTableRow>
</CalendarTableBody>
```

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
