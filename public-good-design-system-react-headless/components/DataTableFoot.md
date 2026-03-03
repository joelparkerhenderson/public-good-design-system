# DataTableFoot

The footer section of a DataTable, rendered as a `<tfoot>` element. Contains DataTableRow elements with summary or aggregate data cells.

## Props

- `children`: ReactNode (required) -- DataTableRow elements with footer cells
- `...restProps`: unknown -- additional attributes spread onto the `<tfoot>`

## Usage

```tsx
<DataTableFoot>
  <DataTableRow>
    <DataTableData>Total</DataTableData>
    <DataTableData>$50,000</DataTableData>
  </DataTableRow>
</DataTableFoot>
```

## References

- HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
