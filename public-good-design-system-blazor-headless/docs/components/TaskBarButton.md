# TaskBarButton

A task bar button is a single button within a task bar, rendered as a native `<button>` element for proper keyboard and screen reader support. It is designed to be placed inside a TaskBar container that manages layout and grouping.

The component uses `<button type="button">` to avoid unintended form submissions and supports the `disabled` attribute for disabling interaction. Content is provided through the ChildContent render fragment, allowing full flexibility in button content.

## Implementation Notes

- Renders as a `<button type="button">` element for native button semantics
- Supports a `disabled` prop to disable the button
- Content is provided through the Blazor 5 `ChildContent` RenderFragment
- Passes through all additional HTML attributes via `AdditionalAttributes`
- Designed to be placed inside a TaskBar container

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TaskBarButton>New Task</TaskBarButton>
```


## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button (browser default)
- Button is skipped in tab order when `disabled` is true

## ARIA Attributes

- Implicit `button` role from the `<button>` element
- `disabled` attribute communicates disabled state to assistive technology
