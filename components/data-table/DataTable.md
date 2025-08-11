# DataTable

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
- `children`: Snippet (required) -- table content including thead, tbody, tr, th, td elements

## Usage

```svelte
<DataTable caption="User accounts">
  <thead><tr><th scope="col">Name</th><th scope="col">Email</th></tr></thead>
  <tbody><tr><td>Alice</td><td>alice@example.com</td></tr></tbody>
</DataTable>
```

```svelte
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

## References

- WAI-ARIA Table Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/table/
- WAI Tutorial on Tables: https://www.w3.org/WAI/tutorials/tables/
