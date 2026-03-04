# Data Table Data

A data table data cell represents a single piece of data within a data table row. It holds the value for one field of a record. It is designed to be used inside a DataTableRow or `<tr>` within a DataTable structure.

The component renders a `<td>` element and passes through its children, which are the cell content.

## Implementation Notes

- Renders as a `<td>` element for a single data cell in a table row
- Children are the cell content (text, numbers, or other elements)
- Designed to be used inside DataTableRow or `<tr>` within a DataTable
- Spreads `restProps` onto the `<td>` element for consumer customization (e.g., `colspan`, `rowspan`, `headers`)
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- cell content
- `...restProps`: Any additional HTML attributes passed to the `<td>` element

## Usage

```html
<DataTableRow>
  <DataTableData>Alice</DataTableData>
  <DataTableData>alice@example.com</DataTableData>
  <DataTableData>Admin</DataTableData>
</DataTableRow>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation within the table follows standard browser behavior.

## ARIA

- Implicit `cell` role from the `<td>` element -- identifies the element as a cell within a table row

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
