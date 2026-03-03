# DataTableBody

The body section of a DataTable, rendered as a `<tbody>` element. Contains DataTableRow elements with data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DataTableBody>
  <DataTableRow>
    <DataTableData>Alice</DataTableData>
    <DataTableData>alice@example.com</DataTableData>
  </DataTableRow>
</DataTableBody>
```



## References

- HTML tbody element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody
