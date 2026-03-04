# Data Table Head

A data table head is the header section of a data table, wrapping one or more rows that label the columns of the table. Typically contains a single row with `<th>` elements that identify each column. It is designed to be used inside a DataTable `<table>` structure.

The component renders a `<thead>` element and passes through its children, which are expected to be DataTableRow or `<tr>` elements containing `<th>` header cells with appropriate `scope` attributes.

## Implementation Notes

- Renders as a `<thead>` element for the header section of a data table
- Children should be one or more rows with `<th scope="col">` cells labeling table columns
- Designed to be used inside a DataTable `<table>` structure
- Spreads `restProps` onto the `<thead>` element for consumer customization
- No internal state -- purely a structural wrapper

## Props

- `children`: slot (required) -- header rows containing column labels
- `...restProps`: Any additional HTML attributes passed to the `<thead>` element

## Usage

```html
<DataTable caption="User accounts">
  <DataTableHead>
    <tr><th scope="col">Name</th><th scope="col">Email</th><th scope="col">Role</th></tr>
  </DataTableHead>
  <DataTableBody>...</DataTableBody>
</DataTable>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation within the table follows standard browser behavior.

## ARIA

- Implicit `rowgroup` role from the `<thead>` element -- groups the header rows of the table

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
