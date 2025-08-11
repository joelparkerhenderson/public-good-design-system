# CalendarTableBody

The body section of a CalendarTable, rendered as a `<tbody>` element. Contains CalendarTableRow elements with day data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CalendarTableBody>
  <CalendarTableRow>
    <CalendarTableData>1</CalendarTableData>
    <CalendarTableData>2</CalendarTableData>
  </CalendarTableRow>
</CalendarTableBody>
```



## References

- HTML tbody element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tbody
