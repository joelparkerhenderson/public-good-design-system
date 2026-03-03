# ThemeView

ThemeView is a headless component that displays the current theme name as inline text. It renders the theme value in a `<span>` element with an accessible label, making the current theme selection readable by screen readers.

This component is commonly paired with ThemePicker in an Input/View pattern. While ThemePicker allows the user to select a theme, ThemeView displays the currently active theme. It is useful in settings panels, status bars, or anywhere the current theme needs to be communicated visually and programmatically.

## Implementation Notes

- Renders a `<span>` element containing the theme value as text content
- Uses `aria-label` to provide an accessible name for the displayed value
- Both `label` and `value` are required props
- Spreads `AdditionalAttributes` onto the span for consumer customization
- Blazor 5 pattern: standard `$props()` destructuring with typed props

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string` | `—` | The value value |

## Usage


```razor
<ThemeView label="Current theme" value="dark" />
```


## Keyboard Interactions

None -- this component is a passive display element with no interactive behavior.

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name describing what the displayed value represents

## References

- WAI-ARIA Accessible Name: https://www.w3.org/TR/accname-1.2/
