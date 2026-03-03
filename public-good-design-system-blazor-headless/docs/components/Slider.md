# Slider

A slider is a UI/UX component that allows users to select a numeric value by dragging a handle along a track, typically used for adjusting settings like volume, brightness, price ranges, or timelines. It provides an intuitive and interactive way to input data within a defined minimum and maximum range.

This headless component wraps a native `<input type="range">` element with configurable min, max, and step values, providing two-way binding for reactive state management and an accessible label for screen readers.

## Implementation Notes

- Uses a native `<input type="range">` element for built-in browser slider behavior
- Supports `@bind-` for two-way binding of the `value` prop
- Accepts `AdditionalAttributes` for forwarding additional attributes to the input element
- No internal state management beyond the bindable value -- relies on native input behavior

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
<Slider label="Volume" @bind-Value min=@0 max=@100 step=@5 />
```


## Keyboard Interactions

- Left Arrow / Down Arrow: Decrease value by one step
- Right Arrow / Up Arrow: Increase value by one step
- Home: Set to minimum value
- End: Set to maximum value
- Page Up: Increase by a larger step (browser-dependent)
- Page Down: Decrease by a larger step (browser-dependent)

(These are provided by the native `<input type="range">` element.)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the slider

## References

- WAI-ARIA Slider Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/slider/
- MDN input type="range": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/range
