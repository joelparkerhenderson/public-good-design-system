# PostalCodeInput

A postal code input provides a text field specifically designed for entering postal or ZIP codes. It includes `autocomplete="postal-code"` to enable browsers to auto-fill the value from stored address data, streamlining address form completion.

This component is useful in address forms, checkout flows, shipping calculators, and any interface that requires postal code entry. It pairs with PostalCodeView for displaying the entered value in read-only contexts. The bindable value prop supports two-way data binding with the parent component.

## Implementation Notes

- Renders a native `<input type="text">` element (not `type="number"`, since postal codes may contain letters or dashes)
- Uses `autocomplete="postal-code"` to hint browser autofill for postal/ZIP code fields
- Uses `aria-label` for accessible naming (no visible label element included; consumers can add their own)
- Uses `@bind-` for the `value` prop, enabling `@bind-Value` in the parent
- Uses Blazor `@bind-Value` internally for reactive two-way binding
- Supports standard HTML form attributes: `required`, `disabled`
- Spreads `AdditionalAttributes` for consumer customization (e.g., `placeholder`, `pattern`, `maxlength`)

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
<PostalCodeInput label="Postal code" @bind-Value />
```


```razor
<PostalCodeInput label="ZIP code" @bind-Value="zipCode" required=@true />
```


```razor
<PostalCodeInput label="Postcode" @bind-Value="postcode" placeholder="SW1A 1AA" />
```


## Keyboard Interactions

None beyond native input behavior -- standard text editing keys (typing, backspace, selection, clipboard-copy-button shortcuts) are handled by the browser.

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the input since no visible `<label>` element is included

## References

- HTML autocomplete attribute: https://developer.mozilla.org/en-US/docs/Web/HTML/Attributes/autocomplete
- MDN input type="text": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/text
