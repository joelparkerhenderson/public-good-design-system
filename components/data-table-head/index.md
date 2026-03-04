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

## When to Use

- Use a DataTableHead to wrap the header row(s) of a DataTable, providing column labels that describe the data below.
- Use a DataTableHead to enable sticky header behavior in scrollable tables.
- Avoid using a DataTableHead outside of a DataTable; it requires a parent `<table>` for valid HTML structure.

## Headless

This headless DataTableHead component provides a semantic `<thead>` element with implicit `rowgroup` role for assistive technology. The consumer provides all visual styling including header background color, font weight, border separation from body rows, and sticky positioning.

## Advice

- **Designers**: Make header cells visually distinct from data cells with bold text, a contrasting background, or a bottom border. Consider sticky headers for long tables.
- **Developers**: Use `<th scope="col">` for column headers within the DataTableRow children. For multi-row headers, use `scope` and `headers` attributes to maintain accessibility.

## Composition

DataTableHead is part of the DataTable composition pattern. It sits inside a DataTable and contains DataTableRow components with `<th>` header cells. The full hierarchy is DataTable > DataTableHead/DataTableBody/DataTableFoot > DataTableRow > DataTableData.

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
