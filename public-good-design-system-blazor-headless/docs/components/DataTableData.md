# DataTableData

A single data cell within a DataTableRow. Renders as a `<td>` with `role="gridcell"`. Supports an active state for indicating the currently focused or selected cell, communicated via `aria-selected`. Uses a roving tabindex pattern.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Active` | `bool` | `—` | The active value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<DataTableRow>
  <DataTableData>Alice</DataTableData>
  <DataTableData active>Bob</DataTableData>
</DataTableRow>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
