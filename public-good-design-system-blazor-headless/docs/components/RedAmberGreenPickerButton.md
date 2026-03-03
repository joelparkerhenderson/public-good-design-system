# RedAmberGreenPickerButton

A button representing one Red/Amber/Green status choice within a RAG status picker. Renders a `<button>` with `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.

Compound component: use with RedAmberGreenPicker.

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
<RedAmberGreenPickerButton value="red" label="Red" selected={status === "red"} @onclick="HandleClick" />
<RedAmberGreenPickerButton value="amber" label="Amber" selected={status === "amber"} @onclick="HandleClick" />
<RedAmberGreenPickerButton value="green" label="Green" selected={status === "green"} @onclick="HandleClick" />
```



## ARIA Attributes

- `aria-label` -- accessible name for the button
- `aria-pressed` -- indicates whether the status is currently selected
- `data-value` -- exposes the status value for consumer CSS selectors

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
- Traffic Light Rating System: https://en.wikipedia.org/wiki/Traffic_light_rating_system
