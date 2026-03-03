# MeasurementInstanceInput

A measurement instance input provides a text field for entering a specific measurement value, such as "72 kg", "98.6 F", or "120/80 mmHg". A measurement instance represents an individual recorded measurement with both its numeric value and unit.

The component uses `aria-label` for accessible labeling in a headless context, and the `value` prop is two-way bindable for reactive form integration. It supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Uses `<input type="text">` with `aria-label` for accessible naming
- A measurement instance is a specific measured value (e.g., "72 kg", "98.6 F")
- Bindable `value` prop for two-way data binding via `@bind-`
- Supports `required` and `disabled` HTML attributes
- Spreads `AdditionalAttributes` on the root `<input>` element
- All text content comes through props for internationalization

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
<MeasurementInstanceInput label="Weight" @bind-Value />
<MeasurementInstanceInput label="Temperature" @bind-Value required />
```


## Keyboard Interactions

- Native `<input type="text">` keyboard behavior (typing, selection, clipboard-copy-button)

## ARIA Attributes

- `aria-label` -- set from the `label` prop to provide an accessible name
