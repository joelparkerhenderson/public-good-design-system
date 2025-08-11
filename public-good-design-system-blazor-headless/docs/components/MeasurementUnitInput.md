# MeasurementUnitInput

A measurement unit input provides a text field for entering a measurement unit, such as "kg", "lb", "cm", "inch", "F", or "C". A measurement unit is a standard quantity used to express a physical measurement.

The component uses `aria-label` for accessible labeling in a headless context, and the `value` prop is two-way bindable for reactive form integration. It supports `required` and `disabled` states for form validation and conditional interactivity.

## Implementation Notes

- Uses `<input type="text">` with `aria-label` for accessible naming
- A measurement unit is a standard quantity (e.g., "kg", "lb", "cm", "inch")
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
<MeasurementUnitInput label="Unit" @bind-Value />
<MeasurementUnitInput label="Unit of measure" @bind-Value required />
```


## Keyboard Interactions

- Native `<input type="text">` keyboard behavior (typing, selection, clipboard-copy-button)

## ARIA Attributes

- `aria-label` -- set from the `label` prop to provide an accessible name
