# Data Table Foot

A data table foot is the footer section of a data table, wrapping one or more rows that provide summary information such as totals, averages, or other aggregate data. It is designed to be used inside a DataTable `<table>` structure.

The component renders a `<tfoot>` element and passes through its children, which are expected to be DataTableRow or `<tr>` elements.

## Implementation Notes

- Renders as a `<tfoot>` element for the footer section of a data table
- Children should be one or more rows providing summary or aggregate information
- Designed to be used inside a DataTable `<table>` structure
- Spreads `restProps` onto the `<tfoot>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- footer rows with summary or aggregate content
- `...restProps`: Any additional HTML attributes passed to the `<tfoot>` element

## Usage

```html
<DataTable caption="Quarterly sales">
  <DataTableHead>...</DataTableHead>
  <DataTableBody>...</DataTableBody>
  <DataTableFoot>
    <tr><th scope="row">Total</th><td>$42,000</td></tr>
  </DataTableFoot>
</DataTable>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation within the table follows standard browser behavior.

## ARIA

- Implicit `rowgroup` role from the `<tfoot>` element -- groups the footer rows of the table

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
