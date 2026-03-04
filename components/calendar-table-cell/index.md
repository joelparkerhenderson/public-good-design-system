# Calendar Table Cell

A calendar board item represents a single day cell within a calendar grid, supporting `aria-selected` for the chosen date and `aria-current="date"` for today. It is designed to be used inside a CalendarTable `<table>` / `<tr>` structure.

The component uses a roving tabindex pattern where the selected cell has `tabindex="0"` and all other cells have `tabindex="-1"`, enabling keyboard focus management within the calendar grid. Content is typically the day number, provided through the children snippet.

## Implementation Notes

- Renders as a `<td>` element with `role="gridcell"` for a single day cell in a calendar grid
- Supports `selected` and `today` states for visual and accessible indication
- Uses roving tabindex pattern: `tabindex="0"` when selected, `-1` otherwise
- `aria-selected` and `aria-current` are set conditionally (omitted when falsy via `|| undefined`)
- Content is provided through the children snippet (typically the day number)
- Designed to be used inside a CalendarTable `<table>` / `<tr>` structure

## Props

- `selected`: boolean (default: false) -- whether this day cell is selected
- `today`: boolean (default: false) -- whether this day cell represents today's date
- `children`: Snippet (required) -- day content, typically the day number
- `...restProps`: Any additional HTML attributes passed to the `<td>` element

## Usage

```svelte
<CalendarTableCell selected today>15</CalendarTableCell>
```

## Keyboard Interactions

- Tab: Focus moves to the selected cell (`tabindex="0"`)
- Arrow keys: Typically handled by the parent CalendarTable grid navigation

## ARIA

- `role="gridcell"` -- identifies the cell as part of a grid
- `aria-selected` -- set to `true` when the cell is selected; omitted otherwise
- `aria-current="date"` -- set when the cell represents today's date; omitted otherwise

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
