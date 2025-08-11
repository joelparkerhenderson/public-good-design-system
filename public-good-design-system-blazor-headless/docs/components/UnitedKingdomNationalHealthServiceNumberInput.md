# UnitedKingdomNationalHealthServiceNumberInput

A United Kingdom National Health Service (NHS) number input is a specialized
form field for entering a 10-digit NHS patient identifier. The NHS number is
assigned to every patient registered with the National Health Service in
England, Wales, and the Isle of Man, and is used to uniquely identify
individuals across the health system.

The standard display format is "XXX XXX XXXX" (three groups of digits separated
by spaces). This input component enforces that pattern, uses a numeric keyboard
hint for mobile devices, and disables autocomplete to protect sensitive health
information. The component supports required and disabled states, and provides
accessible labeling for screen readers.

## Implementation Notes

- Renders as `<input type="text">` with pattern validation for NHS number format
- Pattern: `[0-9]{3} [0-9]{3} [0-9]{4}` (XXX XXX XXXX)
- `inputmode="numeric"` for numeric keyboard on mobile
- `autocomplete="off"` to protect sensitive health identifiers
- Supports `@bind-Value` for two-way binding via `@bind-`
- Pattern is defined as a constant to avoid Blazor template expression parsing of curly braces

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
@code {

  private string nhsNumber = "";;
}

<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" />
```

With two-way binding:

```razor
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" @bind-Value="nhsNumber" />
```

Required field in a form:

```razor
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" required />
```

Disabled state:

```razor
<UnitedKingdomNationalHealthServiceNumberInput label="NHS Number" disabled />
```


## Keyboard Interactions

- Standard text input keyboard behavior
- Users type digits and spaces in the format XXX XXX XXXX

## ARIA Attributes

- `aria-label` provides accessible name from label prop
- `required` and `disabled` states conveyed to assistive technology
- `inputmode="numeric"` hints mobile assistive technology to present a numeric keyboard

## References

- NHS Number format: https://www.nhs.uk/nhs-services/online-services/find-nhs-number/
