# ToggleGroup

ToggleGroup is a headless container for a collection of related toggle buttons. It uses the ARIA `group` role with an accessible label to semantically associate toggle buttons, making their relationship understandable to assistive technologies.

This component is useful for text formatting toolbars (bold, italic, underline), view mode selectors, or any interface where multiple options can be independently toggled on or off. Each child button should use `aria-pressed` to indicate its toggle state. Consumers provide the individual toggle buttons as children and bring their own styling.

## Implementation Notes

- Renders a `<div>` with `role="group"` to semantically group child toggle buttons
- Uses `aria-label` for an accessible name describing the group
- Accepts a `ChildContent` RenderFragment for rendering toggle button elements inside the group
- Spreads `AdditionalAttributes` onto the container for consumer customization
- Blazor 5 pattern: standard `$props()` destructuring with typed props

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ToggleGroup label="Text formatting">
  <button aria-pressed="true">Bold</button>
  <button aria-pressed="false">Italic</button>
</ToggleGroup>
```


## Keyboard Interactions

None at the container level. Keyboard behavior depends on the child toggle button elements provided by the consumer (typically Tab to navigate between buttons, Enter/Space to toggle).

## ARIA Attributes

- `role="group"` -- identifies the container as a semantic grouping of related toggle buttons
- `aria-label={label}` -- provides an accessible name describing the purpose of the toggle collection

## References

- WAI-ARIA group role: https://www.w3.org/TR/wai-aria-1.2/#group
- WAI-ARIA Button Pattern (toggle): https://www.w3.org/WAI/ARIA/apg/patterns/button/
