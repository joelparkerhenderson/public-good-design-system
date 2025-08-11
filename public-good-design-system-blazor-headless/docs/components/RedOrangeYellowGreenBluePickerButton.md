# RedOrangeYellowGreenBluePickerButton

A button representing one Red/Orange/Yellow/Green/Blue status choice within a ROYGB status picker. Renders a `<button>` with `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.

Compound component: use with RedOrangeYellowGreenBluePicker.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string` | `—` | The value value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Selected` | `bool` | `—` | The selected value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<RedOrangeYellowGreenBluePickerButton value="red" label="Red" selected={status === "red"} @onclick="HandleClick" />
<RedOrangeYellowGreenBluePickerButton value="orange" label="Orange" selected={status === "orange"} @onclick="HandleClick" />
<RedOrangeYellowGreenBluePickerButton value="yellow" label="Yellow" selected={status === "yellow"} @onclick="HandleClick" />
<RedOrangeYellowGreenBluePickerButton value="green" label="Green" selected={status === "green"} @onclick="HandleClick" />
<RedOrangeYellowGreenBluePickerButton value="blue" label="Blue" selected={status === "blue"} @onclick="HandleClick" />
```



## ARIA Attributes

- `aria-label` -- accessible name for the button
- `aria-pressed` -- indicates whether the status is currently selected
- `data-value` -- exposes the status value for consumer CSS selectors

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
- Traffic Light Rating System: https://en.wikipedia.org/wiki/Traffic_light_rating_system
