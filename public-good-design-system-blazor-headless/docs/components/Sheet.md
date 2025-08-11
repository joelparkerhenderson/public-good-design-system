# Sheet

Sheet is a headless sliding panel overlay that appears from an edge of the viewport. It functions as a modal dialog with focus trapping semantics and Escape key support, commonly used for navigation menus, settings panels, detail views, or filter interfaces.

Use Sheet when you need a temporary panel that slides in from the top, right, bottom, or left edge of the screen. The component is conditionally rendered based on its `open` state and exposes a `data-side` attribute indicating which edge it appears from, allowing consumers to apply appropriate slide-in animations and positioning via CSS.

## Implementation Notes

- Conditionally renders a `<div>` element with `role="dialog"` only when `open` is `true`
- Sets `aria-modal="true"` to indicate the dialog is modal and should trap focus
- Sets `tabindex="-1"` to allow programmatic focus on the dialog container
- Exposes a `data-side` attribute with the value of the `side` prop for CSS targeting
- Handles Escape key via an `onkeydown` handler that sets `open` to `false`
- Uses Blazor 5 `@bind-` for the `open` prop, enabling `@bind-Open` from the parent
- Consumer is responsible for focus management (moving focus into the sheet when opened)
- Spreads `AdditionalAttributes` onto the dialog div for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Open` | `bool` | `—` | The open value |
| `OpenChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Open |
| `Side` | `string?` | `right` | The side value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Sheet label="Settings" @bind-Open side="right">
  <p>Sheet content</p>
</Sheet>
```


## Keyboard Interactions

- Escape: Closes the sheet by setting `open` to `false`
- Tab: Moves focus between focusable elements within the sheet (consumer should implement focus trapping)

## ARIA Attributes

- `role="dialog"` -- identifies the sheet as a dialog window
- `aria-label={label}` -- provides an accessible name for the dialog
- `aria-modal="true"` -- indicates the dialog is modal, meaning content behind it is inert

## References

- WAI-ARIA Dialog (Modal) Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/
- WAI-ARIA Authoring Practices - Dialog: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/examples/dialog/
