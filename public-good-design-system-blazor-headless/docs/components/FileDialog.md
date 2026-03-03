# FileDialog

A file dialog provides a modal dialog for file-related operations such as opening, saving, or managing files. It renders a native `<dialog>` element conditionally based on its `open` state, with accessible labelling and keyboard dismissal support.

This component is useful in applications that need custom file operation interfaces, such as file managers, document editors, or content management systems. The consumer provides all dialog content -- file lists, action buttons, and navigation controls -- as children.

## Implementation Notes

- Conditionally renders a `<dialog open>` element only when `open` is true
- Uses `@bind-` on the `open` prop for two-way state binding
- Uses the native `<dialog>` HTML element with the `open` attribute
- Sets `tabindex="-1"` to allow the dialog to receive focus programmatically
- Escape key handler sets `open` to `false`
- Spreads `AdditionalAttributes` onto the `<dialog>` for consumer customization

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
<FileDialog label="Open file" @bind-Open>
  <ul>
    <li>document.txt</li>
    <li>image.png</li>
  </ul>
  <button @onclick="HandleClick">Cancel</button>
</FileDialog>
```


## Keyboard Interactions

- Escape: closes the dialog by setting `open` to `false`

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the dialog
- Native `<dialog>` element -- provides implicit `role="dialog"` semantics

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/dialog-modal/
- MDN dialog element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/dialog
