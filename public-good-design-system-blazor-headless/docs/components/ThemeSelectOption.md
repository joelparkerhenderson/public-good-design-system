# ThemeSelectOption

A theme select option is a single `<option>` element for use inside a ThemeSelect dropdown. It represents one available theme choice such as light, dark, high-contrast, or system default. The component wraps the native HTML `<option>` element with Blazor 5 runes and accepts a value prop for the theme identifier and children for the visible label text.

Supports `selected` for pre-selecting a theme and `disabled` for preventing selection, both using native HTML attributes. All accessibility behavior is provided automatically by the browser's native `<option>` element within the parent `<select>`.

## Implementation Notes

- Wraps native `<option>` element with Blazor 5 runes
- Uses `ChildContent` RenderFragment for label text content
- Supports `selected` and `disabled` HTML attributes
- Spreads `AdditionalAttributes` on the root `<option>` element
- Must be used inside a ThemeSelect component for proper semantics
- All text content comes through children and props for internationalization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string` | `—` | The value value |
| `Selected` | `bool` | `—` | The selected value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ThemeSelect label="Theme" @bind-Value="theme">
  <ThemeSelectOption value="light">Light</ThemeSelectOption>
  <ThemeSelectOption value="dark">Dark</ThemeSelectOption>
  <ThemeSelectOption value="high-contrast">High Contrast</ThemeSelectOption>
  <ThemeSelectOption value="system">System Default</ThemeSelectOption>
</ThemeSelect>
```


## Keyboard Interactions

- Native `<option>` keyboard behavior (managed by parent ThemeSelect / `<select>`)

## ARIA Attributes

- Native `<option>` provides built-in accessibility via the parent `<select>` element
- Screen readers announce the option text and selected state automatically

## References

- HTML option element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option
