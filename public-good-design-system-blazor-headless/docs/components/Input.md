# Input

An input provides a headless text input field with accessible labeling and two-way value binding. It serves as the foundational form input component for text entry, supporting various HTML input types such as text, email, password, number, search, and more.

The component supports bindable value state, required and disabled attributes, and spreads additional props for full consumer control over the native `<input>` element.

## Implementation Notes

- Renders a single `<input>` element with the specified `type` attribute.
- Uses `aria-label` for accessible naming since there is no built-in visible `<label>` element.
- The `value` prop uses `$bindable("")` for two-way binding of the input text.
- The `type` prop defaults to `"text"` but accepts any valid HTML input type string.
- Supports native `required` and `disabled` attributes.
- Spreads `AdditionalAttributes` onto the `<input>` for consumer customization (e.g., `placeholder`, `maxlength`, `pattern`).

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Type` | `string?` | `text` | HTML element type attribute |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<Input label="Search" @bind-Value />
```


```razor
<Input label="Name" @bind-Value type="text" required />
```


```razor
<Input label="Email address" @bind-Value type="email" required disabled=@isSubmitting />
```


## Keyboard Interactions

None -- this component uses the native `<input>` element, which provides built-in keyboard support (Tab to focus, standard text editing keys).

## ARIA Attributes

- `aria-label` -- provides an accessible name for the input when no visible label is present.

## References

- MDN Input element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input
- WAI-ARIA Forms: https://www.w3.org/WAI/tutorials/forms/
