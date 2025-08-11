# DateField

A date field provides a fully labeled date input with built-in support for descriptions and error messages. It wraps a native `<input type="date">` with a visible `<label>`, optional helper text, and validation error display, all properly linked via generated IDs for accessibility.

This component is ideal for forms that require date input with validation feedback. The `value` prop is bindable, allowing two-way data flow with the parent component. Error messages are announced to screen readers via `role="alert"`, and the input's invalid state is communicated through `aria-invalid` and `aria-errormessage`.

## Implementation Notes

- Renders a `<div>` wrapper containing a `<label>`, `<input type="date">`, optional description `<p>`, and optional error `<p>`
- Auto-generates a unique ID for the input if none is provided, using `$derived()` for reactivity
- Derives `descriptionId` and `errorId` from the input ID for ARIA linking
- Uses `@bind-` for two-way binding on the `value` prop
- Error paragraph uses `role="alert"` for live announcement to screen readers

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Description` | `string?` | `—` | The description value |
| `Error` | `string?` | `—` | The error value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Id` | `string?` | `—` | The id value |

## Usage


```razor
<DateField label="Start date" @bind-Value />
```


```razor
<DateField label="End date" @bind-Value error="Required" required />
```


```razor
<DateField label="Birthday" @bind-Value description="Format: YYYY-MM-DD" />
```


## Keyboard Interactions

None beyond native `<input type="date">` keyboard behavior, which varies by browser.

## ARIA Attributes

- `<label for={inputId}>` -- links the visible label to the input
- `aria-describedby={descriptionId}` -- links the input to its description text when present
- `aria-invalid="true"` -- indicates the input contains an invalid value when an error is present
- `aria-errormessage={errorId}` -- links the input to its error message when present
- `role="alert"` -- on the error paragraph, announces the error message to screen readers

## References

- ARIA Error Handling: https://www.w3.org/WAI/WCAG22/Techniques/aria/ARIA21
- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
