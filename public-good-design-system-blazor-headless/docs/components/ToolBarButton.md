# ToolBarButton

A tool bar button is a single button within a toolbar, rendered as a native `<button>` element for proper keyboard and screen reader support. It is designed to be placed inside a ToolBar container that manages roving focus keyboard navigation.

The component uses `<button type="button">` to avoid unintended form submissions and supports the `disabled` attribute for disabling interaction. Content is provided through the ChildContent render fragment, allowing full flexibility in button content.

## Implementation Notes

- Renders as a `<button type="button">` element for native button semantics
- Supports a `disabled` prop to disable the button
- Content is provided through the Blazor 5 `ChildContent` RenderFragment
- Passes through all additional HTML attributes via `AdditionalAttributes`
- Compound component: must be used inside a ToolBar container that manages keyboard navigation

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ToolBar label="Editor tools">
  <ToolBarButton>Bold</ToolBarButton>
  <ToolBarButton>Italic</ToolBarButton>
  <ToolBarButton disabled>Redo</ToolBarButton>
</ToolBar>
```


## Keyboard Interactions

- Tab: Focus the button (when not inside a ToolBar managing roving focus)
- Enter / Space: Activate the button (browser default)
- Arrow keys: Handled by parent ToolBar for roving focus navigation
- Button is skipped in tab order when `disabled` is true

## ARIA Attributes

- Implicit `button` role from the `<button>` element
- `disabled` attribute communicates disabled state to assistive technology

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
