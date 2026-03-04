# Theme Select Option

A theme select option is a single `<option>` element intended for use within a ThemeSelect dropdown. It represents one available theme choice (e.g. light, dark, high-contrast) and renders as a native `<option>` element for full browser and assistive technology compatibility.

## Help

Use ThemeSelectOption for individual theme choices within a ThemeSelect dropdown. Common scenarios include light/dark mode options, high-contrast themes, and system-default options. Can be used instead of plain `<option>` elements when you want a dedicated component.

## Syntax

```html
<ThemeSelectOption value="...">Label</ThemeSelectOption>
```

## Usage

```html
<ThemeSelect label="Theme" value={value}>
  <ThemeSelectOption value="light">Light</ThemeSelectOption>
  <ThemeSelectOption value="dark">Dark</ThemeSelectOption>
</ThemeSelect>
```

## Props

| Prop           | Type            | Default    | Description                                              |
| -------------- | --------------- | ---------- | -------------------------------------------------------- |
| `value`        | `string`        | `""`       | The value submitted when this option is selected         |
| `disabled`     | `boolean`       | `false`    | Whether this option is disabled                          |
| `children`     | `slot`       | (required) | Display text for the option                              |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<option>` element |

## Examples

With disabled option:

```html
<ThemeSelect label="Theme" value={value}>
  <ThemeSelectOption value="" disabled>Choose a theme...</ThemeSelectOption>
  <ThemeSelectOption value="light">Light</ThemeSelectOption>
  <ThemeSelectOption value="dark">Dark</ThemeSelectOption>
  <ThemeSelectOption value="high-contrast">High Contrast</ThemeSelectOption>
</ThemeSelect>
```

## Keyboard Interactions

- Arrow Up/Down: Navigates between options within the parent select (native browser behavior)
- Enter/Space: Selects the focused option (native browser behavior)

## ARIA

- Native `<option>` element provides built-in accessibility semantics
- `disabled` attribute communicates disabled state to assistive technology
## References

- MDN option element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option
- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
