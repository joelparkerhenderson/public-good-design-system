# Data Table Row

A data table row represents a single row within a data table, typically corresponding to one record. It wraps data cells or header cells in a horizontal sequence. It is designed to be used inside a DataTableHead, DataTableBody, or DataTableFoot section.

The component renders a `<tr>` element and passes through its children, which are expected to be `<td>`, `<th>`, or DataTableData elements.

## Implementation Notes

- Renders as a `<tr>` element for one row in a data table
- Children should be data cells (`<td>` or DataTableData) or header cells (`<th>`)
- Designed to be used inside DataTableHead, DataTableBody, or DataTableFoot
- Spreads `restProps` onto the `<tr>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- cells for this row
- `...restProps`: Any additional HTML attributes passed to the `<tr>` element

## Usage

```html
<DataTableBody>
  <DataTableRow>
    <td>Alice</td><td>alice@example.com</td><td>Admin</td>
  </DataTableRow>
  <DataTableRow>
    <td>Bob</td><td>bob@example.com</td><td>Editor</td>
  </DataTableRow>
</DataTableBody>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation within the table follows standard browser behavior.

## ARIA

- Implicit `row` role from the `<tr>` element -- identifies a row of cells within the table

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
