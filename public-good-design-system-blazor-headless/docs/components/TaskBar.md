# TaskBar

A task bar is a toolbar container for task-related action buttons using the ARIA toolbar role. It provides ArrowLeft/ArrowRight keyboard navigation between items with Home/End keys to jump to first/last items, implementing the roving focus pattern.

Compound component: use with TaskBarButton.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TaskBar label="Tasks">
  <TaskBarButton>New</TaskBarButton>
  <TaskBarButton>Open</TaskBarButton>
  <TaskBarButton>Save</TaskBarButton>
</TaskBar>
```


## Keyboard Interactions

- ArrowRight: Move focus to next item (wraps to first)
- ArrowLeft: Move focus to previous item (wraps to last)
- Home: Move focus to first item
- End: Move focus to last item

## ARIA Attributes

- `role="toolbar"` -- identifies the container as a toolbar widget
- `aria-label` -- provides the accessible name for the toolbar

## References

- WAI-ARIA Toolbar Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/toolbar/
