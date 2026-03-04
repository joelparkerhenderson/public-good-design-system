# Data Table

A data table displays structured information in rows and columns, allowing users to scan, compare, and analyze data. It wraps content in a semantic `<table>` element with proper `<caption>` support for accessibility. Consumers provide their own `<thead>`, `<tbody>`, `<tr>`, `<th>`, and `<td>` elements as children.

The component supports two labelling strategies: a visible `<caption>` element for sighted users and screen readers alike, or an `aria-label` for cases where the caption should not be displayed visually. When a `caption` prop is provided, `aria-label` is omitted to avoid redundancy.

## Implementation Notes

- Renders a semantic `<table>` element
- Conditionally renders a `<caption>` element when the `caption` prop is provided
- Uses `aria-label` only when no `caption` is present, to avoid duplicate accessible names
- Spreads `restProps` onto the `<table>` for consumer customization
- Consumers are responsible for `<thead>`, `<tbody>`, `scope` attributes on `<th>`, and all row/cell structure

## Props

- `caption`: string (default: undefined) -- visible caption text displayed above the table
- `label`: string (default: undefined) -- accessible label used when `caption` is not provided
- `children`: slot (required) -- table content including thead, tbody, tr, th, td elements

## Usage

```html
<DataTable caption="User accounts">
  <thead><tr><th scope="col">Name</th><th scope="col">Email</th></tr></thead>
  <tbody><tr><td>Alice</td><td>alice@example.com</td></tr></tbody>
</DataTable>
```

```html
<DataTable label="Sales data">
  <thead><tr><th scope="col">Month</th><th scope="col">Revenue</th></tr></thead>
  <tbody><tr><td>January</td><td>$10,000</td></tr></tbody>
</DataTable>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation within the table follows standard browser behavior.

## ARIA

- `aria-label={label}` -- provides an accessible name when no visible caption is present
- `<caption>` -- semantic table caption that serves as the accessible name when provided

## When to Use

- Use a DataTable to display structured tabular data that users need to scan, compare, or analyze, such as user lists, financial reports, or inventory records.
- Use a DataTable when data has clear column headers and row relationships that benefit from a grid format.
- Avoid using a DataTable for layout purposes; use CSS grid or flexbox instead. Consider a card-based layout for small datasets on mobile.

## Headless

This headless DataTable component provides a semantic `<table>` element with conditional `<caption>` or `aria-label` for accessible naming. The consumer provides all visual styling including borders, striping, hover highlights, column widths, responsive behavior, and sorting indicators.

## Advice

- **Designers**: Use alternating row colors or borders to improve scanability. Ensure column headers are visually distinct from data cells. Consider horizontal scrolling or responsive stacking for narrow viewports.
- **Developers**: Use the `caption` prop for visible table descriptions or `label` for screen-reader-only names. Always add `scope="col"` or `scope="row"` to `<th>` elements. Use DataTableHead, DataTableBody, DataTableFoot, DataTableRow, and DataTableData for structured composition.

## Composition

DataTable follows the Table/Head/Body/Foot/Row/Data composition pattern. Use DataTable as the root `<table>`, DataTableHead for the `<thead>` with column headers, DataTableBody for the `<tbody>` with data rows, DataTableFoot for optional `<tfoot>` with summary rows, DataTableRow for each `<tr>`, and DataTableData for each `<td>`. Optionally use DataTableCol inside a `<colgroup>` for column-level styling.

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
