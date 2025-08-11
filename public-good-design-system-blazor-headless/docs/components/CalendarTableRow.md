# CalendarTableRow

A single row within a CalendarTable grid. Renders as a `<tr>`, containing CalendarTableData cells for each day in the week.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CalendarTable label="January 2025">
  <CalendarTableBody>
    <CalendarTableRow>
      <CalendarTableData>1</CalendarTableData>
      <CalendarTableData>2</CalendarTableData>
      <CalendarTableData>3</CalendarTableData>
    </CalendarTableRow>
  </CalendarTableBody>
</CalendarTable>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
