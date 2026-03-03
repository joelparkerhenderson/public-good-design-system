# DatetimeLocalInput

A datetime-local input allows users to select both a date and time using the native `<input type="datetime-local">` element. It provides accessible labelling via `aria-label` and a bindable value for reactive form state.

This component is useful for scheduling interfaces, event creation forms, appointment booking, and any scenario where both date and time must be captured in a single field. The value follows the format `YYYY-MM-DDThh:mm`, and the browser provides the native date-time picker UI.

## Implementation Notes

- Renders a single `<input type="datetime-local">` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Uses Blazor 5 `@bind-` for two-way binding on the `value` prop
- The browser provides the native datetime picker UI
- Spreads `AdditionalAttributes` onto the input element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Min` | `string?` | `—` | The min value |
| `Max` | `string?` | `—` | The max value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<DatetimeLocalInput label="Event start" @bind-Value />
```


```razor
<DatetimeLocalInput label="Appointment" @bind-Value min="2024-01-01T08:00" max="2024-12-31T18:00" />
```


```razor
<DatetimeLocalInput label="Departure time" @bind-Value required disabled=@isLocked />
```


## Keyboard Interactions

- Tab: Moves focus to and from the datetime input (native browser behavior)
- Arrow keys: Navigate within the datetime picker fields (native browser behavior)
- Enter: Opens or confirms the datetime picker (native browser behavior)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the datetime input since there is no visible `<label>` element

## References

- MDN datetime-local input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/datetime-local
