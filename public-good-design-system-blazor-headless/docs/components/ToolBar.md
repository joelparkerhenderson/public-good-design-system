# ToolBar

A toolbar is a container for action buttons and controls using the ARIA toolbar role. It provides left/right arrow key navigation between items with Home/End keys to jump to first/last items, implementing the roving focus pattern for efficient keyboard interaction.

The component queries focusable children via `button`, `[role='button']`, and `[tabindex]` selectors, enabling arrow key navigation to wrap around from last to first and vice versa. This allows users to Tab into the toolbar once, then use arrow keys to move between items, and Tab out to continue through the page.

## Implementation Notes

- Renders as a `<div>` with `role="toolbar"` and built-in keyboard navigation
- Arrow keys (Left/Right) move focus between toolbar items using roving focus
- Home/End keys jump to first/last toolbar item
- Focus wraps around from last item to first and vice versa
- Queries focusable items via `button`, `[role='button']`, and `[tabindex]` selectors
- Uses `private field` for the toolbar element reference and `bind:this` for DOM access
- Accessible name is set via `aria-label` from the `label` prop

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<ToolBar label="Editor tools">
  <button>Bold</button>
  <button>Italic</button>
</ToolBar>
```


## Keyboard Interactions

- ArrowRight: Move focus to next item (wraps to first)
- ArrowLeft: Move focus to previous item (wraps to last)
- Home: Move focus to first item
- End: Move focus to last item
- Tab: Enter/exit the toolbar

## ARIA Attributes

- `role="toolbar"` -- identifies the container as a toolbar widget
- `aria-label` -- provides the accessible name for the toolbar

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
