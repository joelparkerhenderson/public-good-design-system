# Field

A field component wraps a form control with its label, description, and error message, providing proper labelling via `for` attribute linking and accessible error announcements. It serves as a generic form field container that works with any input type -- text inputs, selects, textareas, checkboxes, and more.

The component auto-generates IDs for linking the label to its input and for associating description and error elements via ARIA attributes. A visual required indicator (asterisk) is rendered when `required` is true, hidden from screen readers with `aria-hidden`.

## Implementation Notes

- Renders a `<div>` wrapper containing a `<label>`, consumer-provided children, optional description `<p>`, and optional error `<p>`
- Auto-generates a unique ID using `$derived()` if `inputId` is not provided
- Derives `descId` and `errorId` from the field ID for ARIA linking
- The `<label>` uses `for={fieldId}` to link to the consumer's input element
- Required indicator asterisk uses `aria-hidden="true"` to avoid screen reader noise
- Error paragraph uses `role="alert"` for live announcement
- Sets `data-required` attribute on the wrapper div when `required` is true

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Description` | `string?` | `—` | The description value |
| `Error` | `string?` | `—` | The error value |
| `Required` | `bool` | `—` | The required value |
| `InputId` | `string?` | `—` | The input id value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Field label="Name" description="Enter full name">
  <input id="name-input" />
</Field>
```


```razor
<Field label="Email" required error="Email is required">
  <input id="email-input" type="email" />
</Field>
```


## Keyboard Interactions

None -- this component is a passive container. Clicking the label focuses the associated input via the native `for` attribute behavior.

## ARIA Attributes

- `<label for={fieldId}>` -- links the visible label to the input element
- `role="alert"` -- on the error paragraph, announces the error message to screen readers
- `aria-hidden="true"` -- on the required asterisk, prevents screen readers from reading the decorative indicator
- `data-required` -- data attribute on the wrapper for consumer CSS styling

## References

- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
- WAI-ARIA Error Handling: https://www.w3.org/WAI/WCAG22/Techniques/aria/ARIA21
