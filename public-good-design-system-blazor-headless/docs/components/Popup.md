# Popup

A popup is a UI component that temporarily appears over the main content to convey information, prompt user actions, or display additional options without navigating away from the current screen. The Popup component provides a headless conditional dialog overlay that renders its content only when the `open` state is true, using proper dialog semantics for assistive technology.

The component is similar to Popover but is designed as a general-purpose overlay dialog. It uses `@bind-` for the `open` prop, enabling two-way binding so parent components can control visibility. The consumer provides trigger elements, open/close logic, and all content.

## Implementation Notes

- Conditionally renders a `<div>` with `role="dialog"` only when `open` is true
- Uses `@bind-` for the `open` prop, enabling two-way binding with `@bind-Open`
- The `label` prop is required and provides the dialog's accessible name via `aria-label`
- Rest props are spread onto the `<div>` element
- The consumer must provide their own trigger element and manage open/close behavior
- Content is provided via the `ChildContent` snippet

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
@code {
  private bool showPopup = false;;
}

<button @onclick="HandleClick">Open popup</button>
<Popup label="Confirmation" @bind-Open="showPopup">
  <p>Are you sure you want to proceed?</p>
  <button @onclick="HandleClick">Yes</button>
  <button @onclick="HandleClick">No</button>
</Popup>
```


## Keyboard Interactions

- Escape: Consumer should implement closing the popup by setting `open` to false
- Tab: Should trap focus within the popup when open (consumer responsibility)

## ARIA Attributes

- `role="dialog"` -- identifies the popup as a dialog overlay for assistive technology
- `aria-label="..."` -- provides the accessible name for the dialog

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/dialog/
- WAI-ARIA dialog role: https://www.w3.org/TR/wai-aria-1.2/#dialog
