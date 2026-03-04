# Calendar Table Cell

A calendar board item represents a single day cell within a calendar grid, supporting `aria-selected` for the chosen date and `aria-current="date"` for today. It is designed to be used inside a CalendarTable `<table>` / `<tr>` structure.

The component uses a roving tabindex pattern where the selected cell has `tabindex="0"` and all other cells have `tabindex="-1"`, enabling keyboard focus management within the calendar grid. Content is typically the day number, provided through the children slot.

## Implementation Notes

- Renders as a `<td>` element with `role="gridcell"` for a single day cell in a calendar grid
- Supports `selected` and `today` states for visual and accessible indication
- Uses roving tabindex pattern: `tabindex="0"` when selected, `-1` otherwise
- `aria-selected` and `aria-current` are set conditionally (omitted when falsy via `|| undefined`)
- Content is provided through the children slot (typically the day number)
- Designed to be used inside a CalendarTable `<table>` / `<tr>` structure

## Props

- `selected`: boolean (default: false) -- whether this day cell is selected
- `today`: boolean (default: false) -- whether this day cell represents today's date
- `children`: slot (required) -- day content, typically the day number
- `...restProps`: Any additional HTML attributes passed to the `<td>` element

## Usage

```html
<CalendarTableCell selected today>15</CalendarTableCell>
```

## Keyboard Interactions

- Tab: Focus moves to the selected cell (`tabindex="0"`)
- Arrow keys: Typically handled by the parent CalendarTable grid navigation

## ARIA

- `role="gridcell"` -- identifies the cell as part of a grid
- `aria-selected` -- set to `true` when the cell is selected; omitted otherwise
- `aria-current="date"` -- set when the cell represents today's date; omitted otherwise

## When to Use

- Use for individual day cells within a CalendarTableRow inside a CalendarTable grid.
- Use when each cell needs selection state (`aria-selected`) and today indication (`aria-current="date"`) with roving tabindex.
- Avoid using outside of a CalendarTable structure -- the parent grid provides required keyboard navigation context.

## Headless

This component provides a `<td>` with `role="gridcell"`, conditional `aria-selected`, conditional `aria-current="date"`, and roving tabindex pattern, all with zero visual styling. The consumer is responsible for all CSS including cell sizing, selected state highlight, today indicator, hover effects, focus ring, and disabled day styling.

## Advice

- **Designers**: Make the selected date and today's date visually distinct using different background colors or outlines. Ensure a visible focus indicator for keyboard navigation.
- **Developers**: The roving tabindex pattern (`tabindex="0"` on selected, `-1` on others) enables the parent grid to manage focus. Ensure arrow key handlers on the grid move focus between cells.

## Composition

CalendarTableCell is part of the CalendarTable composition pattern:

- **CalendarTable** -- outer `<table>` with `role="grid"`.
- **CalendarTableHead/Body/Foot** -- section groupings.
- **CalendarTableRow** -- `<tr>` representing one week.
- **CalendarTableCell** -- `<td>` representing one day with selection and today state.

```html
<CalendarTableRow>
  <CalendarTableCell>14</CalendarTableCell>
  <CalendarTableCell today selected>15</CalendarTableCell>
  <CalendarTableCell>16</CalendarTableCell>
</CalendarTableRow>
```

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
