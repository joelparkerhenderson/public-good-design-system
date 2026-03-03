# TextInput

A text input provides a single-line text field for entering short text values such as names, titles, or other brief textual data. It wraps the native HTML `<input type="text">` element with accessible labelling and two-way data binding.

This component is suitable for any form field requiring free-text entry. It supports required and disabled states and uses `aria-label` to ensure screen readers announce the field purpose. The bindable `value` prop enables reactive two-way data flow with the parent component.

## Implementation Notes

- Renders a native `<input type="text">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Uses `@bind-` for the `value` prop, enabling `@bind-Value` in the parent
- Uses Blazor `@bind-Value` internally for reactive two-way binding
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads `AdditionalAttributes` for consumer customization (e.g., `placeholder`, `maxlength`, `pattern`)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<TextInput label="Full name" @bind-Value />
```


```razor
<TextInput label="Email" @bind-Value="email" required=@true />
```


```razor
<TextInput label="Notes" @bind-Value="notes" disabled=@true />
```


## Keyboard Interactions

None beyond native input behavior -- standard text editing keys (typing, backspace, selection, clipboard-copy-button shortcuts) are handled by the browser.

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the input since no visible `<label>` element is included

## References

- MDN input type="text": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/text
