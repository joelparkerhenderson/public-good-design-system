# FloatingPanel

A floating panel is a container that overlays page content, typically used for tooltips, popovers, dropdown menus, or contextual UI. It renders conditionally based on an `open` prop, making it suitable for toggle-based visibility patterns. The component is headless, so consumers are responsible for positioning the panel relative to a trigger element using their own CSS.

## Implementation Notes

- Renders a `<div>` with `role="region"` only when the `open` prop is true
- Uses Blazor `{#if open}` block for conditional rendering (fully removed from DOM when closed)
- Accepts a `ChildContent` RenderFragment for panel content
- Provides `aria-label` for accessible naming of the panel region
- Spreads `AdditionalAttributes` for consumer customization (e.g., positioning attributes)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Open` | `bool` | `—` | The open value |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<FloatingPanel open=@showPanel label="Options">
  <p>Panel content</p>
</FloatingPanel>
```


## Keyboard Interactions

None -- this component is a passive container. Consumers should implement focus management and Escape-to-close behavior as needed for their use case.

## ARIA Attributes

- `role="region"` -- identifies the panel as a landmark region
- `aria-label="..."` -- provides an accessible name for the region

## References

- WAI-ARIA Practices - Disclosure Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/disclosure/
