# CalendarTableCol

A column definition within a CalendarTable, rendered as a `<col>` element. Used inside a `<colgroup>` to define column properties such as span. Useful for styling entire columns of the calendar grid (e.g. weekends).

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Span` | `string` | `—` | The span value |

## Usage


```razor
<CalendarTable label="January 2025">
  <colgroup>
    <CalendarTableCol />
    <CalendarTableCol span=@5 />
    <CalendarTableCol />
  </colgroup>
  ...
</CalendarTable>
```



## References

- HTML col element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/col
