# Textarea

A textarea is a headless component that wraps the native HTML `<textarea>` element, providing a multi-line text input area. It is commonly used in forms for comments, messages, descriptions, feedback, code input, and any scenario where users need to enter extended text content.

Unlike a single-line text input, a textarea provides a larger, scrollable text area that supports multiple lines. The component uses `aria-label` for accessible naming and supports two-way binding on the value via Blazor 5 `@bind-`.

## Implementation Notes

- Renders a single `<textarea>` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Uses Blazor 5 `@bind-` for two-way binding on the `value` prop
- The `rows` prop controls the visible height of the text area
- Spreads `AdditionalAttributes` onto the textarea element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Rows` | `string?` | `—` | The rows value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<Textarea label="Comments" @bind-Value rows=@5 />
```


```razor
<Textarea label="Description" @bind-Value="description" required />
```


```razor
<Textarea label="Notes" @bind-Value disabled=@isReadOnly />
```


## Keyboard Interactions

- Tab: Moves focus to and from the textarea (native browser behavior)
- All standard text editing keys function normally within the textarea (native browser behavior)
- Enter: Inserts a new line (does not submit forms, unlike single-line inputs)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the textarea since there is no visible `<label>` element

## References

- MDN textarea element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea
