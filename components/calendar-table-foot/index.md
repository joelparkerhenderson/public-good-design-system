# Calendar Table Foot

A calendar table foot is the footer section of a calendar grid, wrapping one or more rows that provide supplementary information such as week totals, summary data, or navigation controls. It is designed to be used inside a CalendarTable `<table>` structure.

The component renders a `<tfoot>` element and passes through its children, which are expected to be CalendarTableRow or `<tr>` elements.

## Implementation Notes

- Renders as a `<tfoot>` element for the footer section of a calendar grid
- Children should be one or more rows providing summary or supplementary information
- Designed to be used inside a CalendarTable `<table>` structure
- Spreads `restProps` onto the `<tfoot>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- footer rows with summary or supplementary content
- `...restProps`: Any additional HTML attributes passed to the `<tfoot>` element

## Usage

```html
<CalendarTable label="January 2025">
  <CalendarTableHead>...</CalendarTableHead>
  <CalendarTableBody>...</CalendarTableBody>
  <CalendarTableFoot>
    <tr><td colspan="7">5 events this month</td></tr>
  </CalendarTableFoot>
</CalendarTable>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard navigation is handled by the parent CalendarTable grid.

## ARIA

- Implicit `rowgroup` role from the `<tfoot>` element -- groups the footer rows of the grid

## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
