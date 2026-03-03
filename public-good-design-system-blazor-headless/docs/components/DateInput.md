# DateInput

A date input provides a headless native HTML date input element with accessible labelling via `aria-label`. It is a minimal wrapper for `<input type="date">` that leverages the browser's built-in date picker for date selection.

This component is useful in forms where users need to enter a calendar date. The value is stored in ISO 8601 `YYYY-MM-DD` format. It supports min and max constraints to restrict the allowable date range, and integrates with Blazor 5 two-way binding for reactive form state.

## Implementation Notes

- Renders a single `<input type="date">` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Uses Blazor 5 `@bind-` for two-way binding on the `value` prop
- The browser provides the native date picker UI
- Spreads `AdditionalAttributes` onto the input element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |
| `Min` | `string?` | `—` | The min value |
| `Max` | `string?` | `—` | The max value |
| `Required` | `bool` | `—` | The required value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<DateInput label="Birth date" @bind-Value />
```


```razor
<DateInput label="Deadline" @bind-Value min="2024-01-01" max="2024-12-31" />
```


```razor
<DateInput label="Start date" @bind-Value required disabled=@isLocked />
```


## Keyboard Interactions

- Tab: Moves focus to and from the date input (native browser behavior)
- Arrow keys: Navigate within the date picker fields (native browser behavior)
- Enter: Opens or confirms the date picker (native browser behavior)

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name for the date input since there is no visible `<label>` element

## References

- MDN date input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date
