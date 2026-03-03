# CalendarTable

An interactive calendar table that presents dates in a structured grid layout, typically organized by weeks and days, allowing users to view and interact with calendar data at a glance. Renders a `<table>` element with `role="grid"` and an accessible label. Supports an optional visible caption.

Compound component: use with CalendarTableHead, CalendarTableBody, CalendarTableFoot, CalendarTableRow, CalendarTableData, and CalendarTableCol.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Caption` | `string?` | `—` | The caption value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CalendarTable label="January 2025">
  <CalendarTableHead>
    <CalendarTableRow><th>Sun</th><th>Mon</th><th>Tue</th><th>Wed</th><th>Thu</th><th>Fri</th><th>Sat</th></CalendarTableRow>
  </CalendarTableHead>
  <CalendarTableBody>
    <CalendarTableRow>
      <CalendarTableData>1</CalendarTableData>
      <CalendarTableData>2</CalendarTableData>
      <CalendarTableData>3</CalendarTableData>
      <CalendarTableData>4</CalendarTableData>
      <CalendarTableData>5</CalendarTableData>
      <CalendarTableData>6</CalendarTableData>
      <CalendarTableData>7</CalendarTableData>
    </CalendarTableRow>
  </CalendarTableBody>
</CalendarTable>
```



## References

- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
