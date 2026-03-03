# TimePickerInput

A time picker input is a component that allows users to select a specific time of day, often used alongside a date picker in forms, scheduling tools, or booking systems. It provides a structured way to enter time values, reducing input mistakes and improving the user experience compared to free-text entry.

This headless component wraps a native `<input type="time">` element with an accessible label and support for two-way binding of the time value. It supports required and disabled states and delegates all visual presentation to the consumer.

## Implementation Notes

- Uses a native `<input type="time">` element for built-in browser time selection behavior
- Supports `@bind-` for two-way binding of the `value` prop
- Native input handles 12-hour/24-hour format based on browser locale
- Accepts `AdditionalAttributes` for forwarding additional attributes to the input element

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<TimePickerInput label="Appointment time" @bind-Value />
```


```razor
<TimePickerInput label="Departure time" @bind-Value required />
```


## Keyboard Interactions

- Tab: Move focus to/from the time input
- Up Arrow / Down Arrow: Increment/decrement the focused time segment (hours, minutes, AM/PM)
- Left Arrow / Right Arrow: Move between time segments within the input

(These are provided by the native `<input type="time">` element.)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the time input

## References

- MDN input type="time": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/time
