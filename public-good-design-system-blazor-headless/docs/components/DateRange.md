# DateRange

A date range is a component that provides paired start and end date inputs, allowing users to specify a span of time. Commonly used in booking forms, search filters, reporting interfaces, and scheduling tools, the date range component groups two date inputs together with a shared label to communicate that they represent a related pair.

This headless component renders a `<fieldset>` containing two native `<input type="date">` elements, each with its own accessible label. Both the start and end values support two-way binding for reactive state management.

## Implementation Notes

- Renders a `<fieldset>` to semantically group the paired date inputs
- Uses two native `<input type="date">` elements for built-in browser date selection
- Both `start` and `end` use `@bind-` for two-way binding
- Each input has its own `aria-label` for individual identification
- Accepts `AdditionalAttributes` for forwarding additional attributes to the fieldset

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `StartLabel` | `string` | `—` | The start label value |
| `EndLabel` | `string` | `—` | The end label value |
| `Start` | `string?` | `—` | The start value |
| `StartChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Start |
| `End` | `string?` | `—` | The end value |
| `EndChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of End |

## Usage


```razor
<DateRange
    label="Trip dates"
    startLabel="Departure"
    endLabel="Return"
    @bind-Start
    @bind-End
/>
```


## Keyboard Interactions

- Tab: Move focus between the start and end date inputs
- Up Arrow / Down Arrow: Increment/decrement the focused date segment
- Left Arrow / Right Arrow: Move between date segments within an input

(These are provided by the native `<input type="date">` elements.)

## ARIA Attributes

- `aria-label={label}` on `<fieldset>` -- provides an accessible group name for the date range pair
- `aria-label={startLabel}` on the start input -- identifies the start date field
- `aria-label={endLabel}` on the end input -- identifies the end date field

## References

- MDN input type="date": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date
- MDN fieldset element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/fieldset
