# ThemeSelect

A theme select is a headless component that allows users to switch between different visual themes or color schemes using a native `<select>` dropdown. It is commonly used to offer light, dark, high-contrast, or other visual modes, enhancing personalization and accessibility by letting users adapt the interface to their preferences or environment.

The consumer provides ThemeSelectOption elements as children to define the available themes. The component uses `aria-label` for accessible naming and supports two-way binding on the selected theme via Blazor 5 `@bind-`.

## Implementation Notes

- Renders a single `<select>` element containing ThemeSelectOption children
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Uses Blazor 5 `@bind-` for two-way binding on the `value` prop
- Uses Blazor 5 RenderFragment for the `ChildContent` prop to render ThemeSelectOption elements
- The consumer is responsible for applying the selected theme value to the page (e.g., setting a CSS class or data attribute on the document)
- Spreads `AdditionalAttributes` onto the select element for consumer extensibility
- Compound component: pair with ThemeSelectOption for each theme choice

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ThemeSelect label="Theme" @bind-Value>
  <ThemeSelectOption value="light">Light</ThemeSelectOption>
  <ThemeSelectOption value="dark">Dark</ThemeSelectOption>
</ThemeSelect>
```


```razor
<ThemeSelect label="Color scheme" @bind-Value="theme">
  <ThemeSelectOption value="light">Light</ThemeSelectOption>
  <ThemeSelectOption value="dark">Dark</ThemeSelectOption>
  <ThemeSelectOption value="high-contrast">High Contrast</ThemeSelectOption>
  <ThemeSelectOption value="system">System Default</ThemeSelectOption>
</ThemeSelect>
```


## Keyboard Interactions

- Tab: Moves focus to and from the select element (native browser behavior)
- Space/Enter: Opens the dropdown list when focused (native browser behavior)
- Arrow Up/Down: Navigates through theme options (native browser behavior)
- Escape: Closes the dropdown list (native browser behavior)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the theme select since there is no visible `<label>` element

## References

- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
- WCAG 1.4.12 Text Spacing (theme customization): https://www.w3.org/WAI/WCAG22/Understanding/text-spacing.html
