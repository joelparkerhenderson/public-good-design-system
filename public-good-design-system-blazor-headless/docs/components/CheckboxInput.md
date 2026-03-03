# CheckboxInput

A checkbox input is a minimal headless wrapper around the native HTML `<input type="checkbox">` element. Unlike a Checkbox component which includes a wrapping `<label>`, CheckboxInput uses `aria-label` for accessibility, giving consumers full control over label placement and visual presentation.

This component is ideal when you need a bare checkbox that you will wrap in your own custom layout, such as placing the label to the left, using a custom indicator, or integrating into a complex form where label positioning must be controlled by the consumer.

## Implementation Notes

- Renders a single `<input type="checkbox">` element with no wrapper
- Uses `aria-label` for accessible naming instead of a wrapping `<label>` element
- Uses Blazor 5 `@bind-` for two-way binding on the `checked` prop
- Spreads `AdditionalAttributes` onto the input element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Checked` | `bool` | `—` | The checked value |
| `CheckedChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Checked |
| `Label` | `string` | `—` | Accessible label for the component |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `Required` | `bool` | `—` | The required value |
| `Name` | `string?` | `—` | The name value |
| `Id` | `string?` | `—` | The id value |
| `Value` | `string?` | `—` | The value value |

## Usage


```razor
<CheckboxInput label="Accept terms" @bind-Checked />
```


```razor
<CheckboxInput label="Subscribe to newsletter" @bind-Checked="subscribed" disabled={!hasEmail} />
```


```razor
<CheckboxInput label="Required field" @bind-Checked required name="agree" value="yes" />
```


## Keyboard Interactions

- Space: Toggles the checkbox checked state (native browser behavior)
- Tab: Moves focus to and from the checkbox (native browser behavior)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the checkbox since there is no visible `<label>` element

## References

- MDN checkbox input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/checkbox
- WAI-ARIA Checkbox Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/checkbox/
