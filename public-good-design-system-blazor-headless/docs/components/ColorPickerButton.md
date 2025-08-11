# ColorPickerButton

A button representing a single predefined color choice within a ColorPicker. It allows users to select a color from a set of predefined options by clicking on a visually representative swatch. The component communicates selected state through `aria-pressed` and exposes `data-color` for consumer CSS targeting.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Color` | `string` | `—` | The color value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Selected` | `bool` | `—` | The selected value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<ColorPicker label="Choose a color">
  <ColorPickerSwatchButton color="#ff0000" label="Red" @onclick="handleSelect" />
  <ColorPickerSwatchButton color="#0066cc" label="Blue" selected=@true @onclick="handleSelect" />
  <ColorPickerSwatchButton color="#cccccc" label="Gray" disabled=@true />
</ColorPicker>
```



## References

- [WAI-ARIA Button Pattern](https://www.w3.org/WAI/ARIA/apd/patterns/button/)
