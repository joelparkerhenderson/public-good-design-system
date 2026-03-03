# DataTableHead

The header section of a DataTable, rendered as a `<thead>` element. Contains DataTableRow elements with column header cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DataTableHead>
  <DataTableRow><th scope="col">Name</th><th scope="col">Email</th></DataTableRow>
</DataTableHead>
```



## References

- HTML thead element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/thead
