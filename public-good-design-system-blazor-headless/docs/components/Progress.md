# Progress

A progress bar visually indicates the completion status of a task or process using the native HTML `<progress>` element. It is commonly used for file uploads, form submissions, loading sequences, installation wizards, and any process where users benefit from knowing how much of a task has been completed.

The component supports both determinate progress (with a known value and maximum) and indeterminate progress (when the value is undefined, indicating an ongoing process of unknown duration). The native `<progress>` element provides built-in semantic meaning and accessibility support.

## Implementation Notes

- Renders a single `<progress>` element with no wrapper
- When `value` is undefined, the progress bar is indeterminate (the browser displays an animated or pulsing indicator)
- When `value` is a number, the progress bar shows determinate progress as a fraction of `max`
- Uses `aria-label` for accessible naming
- Spreads `AdditionalAttributes` onto the progress element for consumer extensibility

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `Max` | `int` | `100` | The max value |

## Usage


```razor
<Progress label="Upload progress" value=@50 max=@100 />
```


```razor
<Progress label="Loading" />
```


```razor
<Progress label="Installation" value=@3 max=@5 />
```


## Keyboard Interactions

None -- this component is a passive display element that does not accept user input.

## ARIA Attributes

- `aria-label={label}` -- provides an accessible name describing what process the progress bar represents
- The `<progress>` element implicitly has `role="Progress"` with `aria-valuenow`, `aria-valuemin`, and `aria-valuemax` attributes managed by the browser

## References

- MDN progress element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/progress
- WAI-ARIA Progress role: https://www.w3.org/WAI/ARIA/apd/patterns/meter/
