# RangeInput

A range input is a UI/UX component that provides a slider control for selecting a numeric value within a defined range. It uses the native HTML `<input type="range">` element, which renders as a draggable track and handle. The component supports configurable minimum, maximum, and step values, and provides a bindable value prop for two-way data binding. An aria-label ensures the control is accessible to screen readers and assistive technologies.

Range inputs are commonly used for volume controls, brightness settings, price filters, and any scenario where users need to select a value from a continuous numeric spectrum.

## Implementation Notes

- Renders a single `<input type="range">` element for native slider behavior
- Uses `@bind-` for the `value` prop enabling two-way data binding with `@bind-Value`
- Supports additional attributes via `AdditionalAttributes` for extensibility (e.g., `id`, `name`, `class`)
- The `aria-label` prop provides an accessible name since there is no visible `<label>` element
- Default value is 50, centered in the default 0-100 range

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `int` | `50` | The value value |
| `ValueChanged` | `EventCallback<int>` | `—` | Event callback for two-way binding of Value |
| `Min` | `int` | `—` | The min value |
| `Max` | `int` | `100` | The max value |
| `Step` | `int` | `1` | The step value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<RangeInput label="Volume" @bind-Value min=@0 max=@100 />
```


```razor
<RangeInput label="Price range" @bind-Value="price" min=@10 max=@500 step=@10 />
```


## Keyboard Interactions

- Left Arrow / Down Arrow: decrease value by one step
- Right Arrow / Up Arrow: increase value by one step
- Home: set to minimum value
- End: set to maximum value
- Page Down: decrease by a larger step (browser-defined)
- Page Up: increase by a larger step (browser-defined)

Note: keyboard interactions are provided natively by the `<input type="range">` element.

## ARIA Attributes

- `aria-label={label}` -- provides the accessible name for the slider control since no visible label element is associated

## References

- WAI-ARIA Slider Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/slider/
- MDN input type="range": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/range
