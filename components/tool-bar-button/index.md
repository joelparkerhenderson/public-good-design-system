# Tool Bar Button

A tool bar button is a single button within a toolbar, rendered as a native `<button>` element for proper keyboard and screen reader support. It is designed to be placed inside a ToolBar container that manages roving focus keyboard navigation.

The component uses `<button type="button">` to avoid unintended form submissions and supports the `disabled` attribute for disabling interaction. Content is provided through the children snippet, allowing full flexibility in button content.

## Help

Use ToolBarButton for individual action buttons within a ToolBar. Common scenarios include text formatting buttons (Bold, Italic, Underline), drawing tool selectors, or media controls. The parent ToolBar manages keyboard navigation between buttons.

## Syntax

```svelte
<script>
  import ToolBarButton from "./ToolBarButton.svelte";
</script>

<ToolBarButton>Label</ToolBarButton>
```

## Usage

```svelte
<ToolBarButton>Bold</ToolBarButton>
```

```svelte
<ToolBarButton disabled>Redo</ToolBarButton>
```

## Props

| Prop           | Type            | Default    | Description                                            |
| -------------- | --------------- | ---------- | ------------------------------------------------------ |
| `disabled`     | `boolean`       | `false`    | Whether the button is disabled                         |
| `children`     | `Snippet`       | (required) | Button content                                         |
| `...restProps` | HTML attributes |            | Additional attributes passed to the `<button>` element |

## Examples

Inside a ToolBar:

```svelte
<ToolBar label="Text formatting">
  <ToolBarButton>Bold</ToolBarButton>
  <ToolBarButton>Italic</ToolBarButton>
  <ToolBarButton disabled>Strikethrough</ToolBarButton>
</ToolBar>
```

## Keyboard Interactions

- Tab: Focus the button (when not inside a ToolBar managing roving focus)
- Enter / Space: Activate the button (browser default)
- Arrow keys: Handled by parent ToolBar for roving focus navigation
- Button is skipped in tab order when `disabled` is true

## ARIA

- Implicit `button` role from the `<button>` element
- `disabled` attribute communicates disabled state to assistive technology

## Claude Rules

- Always use `ToolBarButton` (not `ToolBarItem`)
- Always place inside a ToolBar container
- Always provide children content for the button label
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
