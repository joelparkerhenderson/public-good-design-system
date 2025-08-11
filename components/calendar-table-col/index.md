# Calendar Table Col

CalendarTableCol is a headless component that renders a `<col>` element within a calendar table column group. It applies column-level attributes and styling hooks for calendar grid columns.

Use this component within a CalendarTable to define column properties such as width or class for individual day columns.

## Implementation Notes

- Renders a `<col>` element for column-level styling within a `<colgroup>`
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<col>` element for consumer customization

## Props

- `className`: string (default: `""`) -- CSS class name for the column
- `...restProps`: unknown -- additional attributes spread onto the `<col>` element

## Usage

```html
<colgroup>
  <CalendarTableCol />
  <CalendarTableCol />
</colgroup>
```

## Keyboard Interactions

None. Column elements are not interactive.

## ARIA

No ARIA attributes. Column elements are structural, not semantic.

## When to Use

- Use within a CalendarTable `<colgroup>` to define column-level properties.
- Avoid using outside of a table context.

## Headless

This headless component renders a `<col>` element. The consumer provides all visual styling including column widths and backgrounds.

## Styles

The consumer provides all CSS styling. The component renders with a `.calendar-table-col` class for targeting.

## Testing

- Verify the component renders a `<col>` element
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use column definitions to set consistent widths across day columns.
- **Developers**: Place CalendarTableCol elements inside a `<colgroup>` within CalendarTable.

## Composition

CalendarTableCol is a child of CalendarTable, following the Table pattern: CalendarTable > CalendarTableHead/CalendarTableBody/CalendarTableFoot > CalendarTableRow > CalendarTableData.

## References

- MDN col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
