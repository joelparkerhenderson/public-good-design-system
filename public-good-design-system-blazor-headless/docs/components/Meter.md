# Meter

Meter is a headless component that displays a scalar measurement within a known range using the native HTML `<meter>` element. It provides accessible labelling and supports optional threshold indicators for low, high, and optimum values.

This component is useful for displaying disk usage, battery level, password strength, performance scores, or any bounded numeric measurement. The native `<meter>` element provides built-in semantics that assistive technologies can interpret, and the text content inside the element serves as a fallback for browsers that do not support the element.

## Implementation Notes

- Renders a native `<meter>` element with the value displayed as fallback text content
- Uses `aria-label` for an accessible name describing what the meter measures
- Supports the full set of `<meter>` attributes: `value`, `min`, `max`, `low`, `high`, `optimum`
- The `min` and `max` props default to 0 and 100 respectively
- `low`, `high`, and `optimum` are optional and default to undefined
- Spreads `AdditionalAttributes` onto the meter for consumer customization
- Blazor 5 pattern: standard `$props()` destructuring with typed props

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string` | `—` | The value value |
| `Min` | `int` | `—` | The min value |
| `Max` | `int` | `100` | The max value |
| `Low` | `string?` | `—` | The low value |
| `High` | `string?` | `—` | The high value |
| `Optimum` | `string?` | `—` | The optimum value |
| `Label` | `string` | `—` | Accessible label for the component |

## Usage


```razor
<Meter label="Disk space" value=@45 max=@100 />
```


## Keyboard Interactions

None -- this component is a passive display element with no interactive behavior.

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name describing what the meter measures

## References

- HTML meter element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/meter
- WAI-ARIA meter role: https://www.w3.org/TR/wai-aria-1.2/#meter
