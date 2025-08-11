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
## When to Use

- Use ThemeSelectOption for individual theme choices inside a ThemeSelect dropdown.
- Use when you want a dedicated component per option rather than plain `<option>` elements, for consistency or added logic.
- Avoid using ThemeSelectOption outside of a ThemeSelect parent; it renders a native `<option>` element that requires a `<select>` context.

## Headless

This headless component provides a native `<option>` element with `value` and `disabled` attributes. Full browser and assistive technology compatibility comes from the native element. The consumer provides the display text as children and all visual styling is handled by the parent select and browser defaults.


## Styles

The consumer provides all CSS styling. The component renders with a `.theme-select-option` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<option>` element with class `theme-select-option`
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Keep option labels short and descriptive (e.g., "Light", "Dark", "High Contrast") so they are scannable in the dropdown.
- **Developers**: Use the `disabled` attribute on a placeholder option (e.g., "Choose a theme...") to prevent it from being selected as a valid value.

## Composition

ThemeSelectOption is a child of ThemeSelect, following the Select/SelectOption pattern. Each ThemeSelectOption represents one available theme choice within the parent dropdown.

## References

- MDN option element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option
- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
