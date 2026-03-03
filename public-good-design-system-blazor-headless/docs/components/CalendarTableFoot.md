# CalendarTableFoot

The footer section of a CalendarTable, rendered as a `<tfoot>` element. Contains CalendarTableRow elements with summary or aggregate data cells.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CalendarTableFoot>
  <CalendarTableRow>
    <CalendarTableData>Week Total: 5</CalendarTableData>
  </CalendarTableRow>
</CalendarTableFoot>
```



## References

- HTML tfoot element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/tfoot
