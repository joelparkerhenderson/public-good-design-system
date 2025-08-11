# DataTableCol

A column definition within a DataTable, rendered as a `<col>` element. Used inside a `<colgroup>` to define column properties such as span. Useful for styling entire columns of the data table.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Span` | `string` | `—` | The span value |

## Usage


```razor
<DataTable label="Users">
  <colgroup>
    <DataTableCol />
    <DataTableCol span=@3 />
  </colgroup>
  ...
</DataTable>
```



## References

- HTML col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
