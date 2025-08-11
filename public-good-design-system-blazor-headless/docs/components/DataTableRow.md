# DataTableRow

A single row within a DataTable. Renders as a `<tr>` containing DataTableData cells or header cells. Used inside DataTableHead, DataTableBody, or DataTableFoot.

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

- HTML tr element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tr
