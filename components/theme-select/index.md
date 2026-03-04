# Theme Select

A theme select is a headless component that allows users to switch between different visual themes or color schemes using a native `<select>` dropdown. It is commonly used to offer light, dark, high-contrast, or other visual modes, enhancing personalization and accessibility by letting users adapt the interface to their preferences or environment.

The consumer provides `<option>` elements as children to define the available themes. The component uses `aria-label` for accessible naming and supports two-way binding on the selected theme.

## Help

Use ThemeSelect when you need a dropdown for switching visual themes. Common scenarios include light/dark mode toggles, high-contrast themes for accessibility, or branded theme options. Pair with ThemeSelectOption for individual options, or use plain `<option>` elements.

## Syntax

```html
<ThemeSelect label="..." value={value}>
  <option value="...">...</option>
</ThemeSelect>
```

## Usage

```html
<ThemeSelect label="Theme" value={value}>
  <option value="light">Light</option>
  <option value="dark">Dark</option>
</ThemeSelect>
```

```html
<ThemeSelect label="Color scheme" value={theme}>
  <option value="light">Light</option>
  <option value="dark">Dark</option>
  <option value="high-contrast">High Contrast</option>
  <option value="system">System Default</option>
</ThemeSelect>
```

## Props

| Prop           | Type            | Default    | Description                                               |
| -------------- | --------------- | ---------- | --------------------------------------------------------- |
| `label`        | `string`        | (required) | Accessible name applied via `aria-label`                  |
| `value`        | `string`        | `""`       | Bindable string representing the currently selected theme |
| `children`     | `slot`       | (required) | `<option>` elements representing available themes         |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<select>` element  |

## Examples

With theme application:

```html
<ThemeSelect label="Choose theme" value={theme}>
  <option value="light">Light</option>
  <option value="dark">Dark</option>
</ThemeSelect>
```

## Keyboard Interactions

- Tab: Moves focus to and from the select element (native browser behavior)
- Space/Enter: Opens the dropdown list when focused (native browser behavior)
- Arrow Up/Down: Navigates through theme options (native browser behavior)
- Escape: Closes the dropdown list (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name for the theme select since there is no visible `<label>` element
## References

- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
- WCAG 1.4.12 Text Spacing (theme customization): https://www.w3.org/WAI/WCAG22/Understanding/text-spacing.html
