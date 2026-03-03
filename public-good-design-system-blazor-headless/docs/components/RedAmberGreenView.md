# RedAmberGreenView

A RAG (Red/Amber/Green) status view is a component that displays a traffic-light status value as read-only text. It is used to present previously captured RAG status data in dashboards, reports, or detail views. Red indicates a critical problem, amber signals caution or minor issues, and green means everything is on track.

The component renders as a `<span>` element with an accessible label, making the status readable by screen readers and other assistive technologies. This headless component provides the semantic structure and accessibility features while allowing consumers to apply their own visual styling, such as color-coded backgrounds or text colors.

## Implementation Notes

- Renders as `<span aria-label={label}>` displaying the RAG status value as text content
- Read-only display component, not interactive
- Value defaults to an empty string when not provided
- Uses Blazor 5 `$props()` rune for prop destructuring
- Spreads `AdditionalAttributes` on the `<span>` element for consumer extensibility
- No hardcoded user-facing strings; label and value are fully configurable

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |

## Usage


```razor
<RedAmberGreenView label="Project status" value="green" />
```


```razor
<RedAmberGreenView label="Health check" value=@status />
```


## Keyboard Interactions

None -- this is a passive informational display, not an interactive element.

## ARIA Attributes

- `aria-label={label}` -- provides the accessible name for the status display, allowing screen readers to announce the context of the value

## References

- WAI-ARIA status role: https://www.w3.org/TR/wai-aria-1.2/#status
