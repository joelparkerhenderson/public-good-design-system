# NumberInput

NumberInput is a headless component that wraps a native `<input type="number">` element with accessible labelling and optional min, max, and step constraints. It provides a bindable numeric value for two-way data flow.

This component is useful for quantity selectors, age inputs, price fields, configuration values, or any form field that accepts numeric input. The native number input provides browser-built-in validation, increment/decrement controls, and appropriate virtual keyboard on mobile devices.

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses `$bindable(undefined)` for two-way binding with an initial undefined state
- Supports optional `min`, `max`, and `step` constraints
- Supports `required` and `disabled` boolean states
- Spreads `AdditionalAttributes` onto the input for consumer customization (e.g., `id`, `name`, `placeholder`)
- Blazor 5 pattern: `$bindable` for the value prop

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Min` | `string?` | `—` | The min value |
| `Max` | `string?` | `—` | The max value |
| `Step` | `string?` | `—` | The step value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<NumberInput label="Quantity" @bind-Value min=@0 max=@100 step=@1 />
```


## Keyboard Interactions

None at the component level. Keyboard behavior is handled natively by the browser's number input implementation (Up/Down arrows to increment/decrement).

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name describing the purpose of the number input

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role (implicit): https://www.w3.org/TR/wai-aria-1.2/#spinbutton
