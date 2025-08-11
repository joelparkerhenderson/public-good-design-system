# UnitedStatesSocialSecurityNumberInput

A United States Social Security Number (SSN) input is a specialized form field
for entering a 9-digit SSN issued by the Social Security Administration. The SSN
is used as a national identifier for taxation, credit reporting, and various
government and private-sector purposes.

The standard display format is "XXX-XX-XXXX" (three groups of digits separated
by hyphens: a 3-digit area number, a 2-digit group number, and a 4-digit serial
number). This input component enforces that pattern, uses a numeric keyboard
hint for mobile devices, and disables autocomplete to protect sensitive
personally identifiable information. The component supports required and disabled
states, and provides accessible labeling for screen readers.

## Implementation Notes

- Renders as `<input type="text">` with pattern validation for SSN format
- Pattern: `[0-9]{3}-[0-9]{2}-[0-9]{4}` (XXX-XX-XXXX)
- `inputmode="numeric"` for numeric keyboard on mobile
- `autocomplete="off"` to protect sensitive PII
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

  private string ssn = "";;
}

<UnitedStatesSocialSecurityNumberInput label="Social Security Number" />
```

With two-way binding:

```razor
<UnitedStatesSocialSecurityNumberInput label="SSN" @bind-Value="ssn" />
```

Required field in a form:

```razor
<UnitedStatesSocialSecurityNumberInput label="Social Security Number" required />
```

Disabled state:

```razor
<UnitedStatesSocialSecurityNumberInput label="Social Security Number" disabled />
```


## Keyboard Interactions

- Standard text input keyboard behavior
- Users type digits and hyphens in the format XXX-XX-XXXX

## ARIA Attributes

- `aria-label` provides accessible name from label prop
- `required` and `disabled` states conveyed to assistive technology
- `inputmode="numeric"` hints mobile assistive technology to present a numeric keyboard

## References

- Social Security Number format: https://www.ssa.gov/employer/randomization.html
