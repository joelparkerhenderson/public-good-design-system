# CalendarTableData

A single day cell within a CalendarTable grid. Renders as a `<td>` with `role="gridcell"`, supporting selected and today states. Uses a roving tabindex pattern where the selected cell receives focus.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Selected` | `bool` | `—` | The selected value |
| `Today` | `bool` | `—` | The today value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CalendarTableData selected today>15</CalendarTableData>
<CalendarTableData>22</CalendarTableData>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
