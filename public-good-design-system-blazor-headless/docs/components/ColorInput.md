# ColorInput

A color input wraps the native HTML `<input type="color">` element, providing a browser-native color picker with accessible labeling. The value is always a hex color string (e.g., "#ff0000"). This component is useful in settings panels, theme editors, or any interface where users need to select a color.

## Implementation Notes

- Renders a native `<input type="color">` element for browser-native color picking
- Uses `@bind-Value` with `@bind-` for two-way binding of the hex color string
- Provides `aria-label` for screen reader accessibility since native color inputs have no visible label
- Supports `disabled`, `name`, and `id` for form integration
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string?` | `#000000` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Name` | `string?` | `—` | The name value |
| `Id` | `string?` | `—` | The id value |

## Usage


```razor
<ColorInput label="Background color" @bind-Value="color" />
```


## Keyboard Interactions

None -- keyboard behavior is provided by the browser-native color input.

## ARIA Attributes

- `aria-label="..."` -- provides an accessible name for the color input since it has no visible `<label>` element

## References

- MDN `<input type="color">`: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/color
