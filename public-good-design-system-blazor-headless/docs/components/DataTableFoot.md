# DataTableFoot

The footer section of a DataTable, rendered as a `<tfoot>` element. Contains DataTableRow elements with summary or aggregate data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DataTableFoot>
  <DataTableRow>
    <DataTableData>Total</DataTableData>
    <DataTableData>$50,000</DataTableData>
  </DataTableRow>
</DataTableFoot>
```



## References

- HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
