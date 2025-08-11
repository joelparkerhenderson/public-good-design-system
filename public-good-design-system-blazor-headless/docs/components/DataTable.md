# DataTable

An interactive data table that displays structured information in rows and columns as a grid widget. Renders a `<table>` element with `role="grid"` and an accessible label. Supports an optional visible caption. Commonly used for sortable tables, editable spreadsheets, and interactive data grids.

Compound component: use with DataTableHead, DataTableBody, DataTableFoot, DataTableRow, DataTableData, and DataTableCol.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Caption` | `string?` | `—` | The caption value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DataTable label="User accounts">
  <DataTableHead>
    <DataTableRow><th scope="col">Name</th><th scope="col">Email</th></DataTableRow>
  </DataTableHead>
  <DataTableBody>
    <DataTableRow>
      <DataTableData>Alice</DataTableData>
      <DataTableData>alice@example.com</DataTableData>
    </DataTableRow>
  </DataTableBody>
</DataTable>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
