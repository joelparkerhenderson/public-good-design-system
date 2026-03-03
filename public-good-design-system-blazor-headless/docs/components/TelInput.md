# TelInput

A telephone input component that provides a telephone number input field using the native HTML `<input type="tel">` element. It includes accessible labeling via `aria-label` and browser autofill support via `autocomplete="tel"`, making it suitable for contact forms, registration flows, and profile editors.

The component supports two-way data binding through a bindable `value` prop, allowing parent components to read and write the telephone number. It also supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Renders as a single `<input type="tel">` element
- Uses `aria-label` for accessible naming (no visible label element included; consumers can wrap with their own `<label>`)
- `autocomplete="tel"` enables browser and password manager autofill for phone numbers
- Bindable `value` prop uses Blazor 5 `@bind-` for two-way data binding
- Supports `required` and `disabled` HTML attributes natively
- Spreads `AdditionalAttributes` onto the `<input>` for additional attributes like `placeholder`, `pattern`, `maxlength`, etc.

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
<TelInput label="Phone number" @bind-Value />
```


```razor
<TelInput label="Mobile" @bind-Value required />
```


## Keyboard Interactions

- Native `<input type="tel">` keyboard behavior applies (Tab to focus, type to enter digits)

## ARIA Attributes

- `aria-label` -- provides the accessible name for the input, set from the `label` prop
- `autocomplete="tel"` -- signals browsers to offer telephone number autofill

## References

- HTML tel input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/tel
