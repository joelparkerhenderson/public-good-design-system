# ProgressCircle

A progress circle indicates completion status using a `<div>` with ARIA Progress semantics. Unlike a linear progress bar, the progress circle is intended to convey progress in a radial layout, commonly used for loading indicators, completion percentages, and dashboard widgets. The component is headless, so consumers provide their own CSS to create the circular visual representation using the ARIA value attributes.

## Implementation Notes

- Renders a `<div>` with `role="Progress"` and full ARIA value attributes
- Provides `aria-valuenow`, `aria-valuemin`, and `aria-valuemax` to communicate progress to screen readers
- Accepts an optional `ChildContent` RenderFragment for content inside the circle (e.g., percentage text)
- Uses `aria-label` for accessible naming
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `int` | `—` | The value value |
| `Min` | `int` | `—` | The min value |
| `Max` | `int` | `100` | The max value |
| `ChildContent` | `RenderFragment?` | `—` | Child content to render inside the component |

## Usage


```razor
<ProgressCircle label="Upload" value=@75>
  <span>75%</span>
</ProgressCircle>
```


## Keyboard Interactions

None -- this component is a passive, read-only display.

## ARIA Attributes

- `role="Progress"` -- identifies the element as a progress indicator
- `aria-label="..."` -- provides an accessible name for the progress indicator
- `aria-valuenow` -- the current progress value
- `aria-valuemin` -- the minimum value of the progress range
- `aria-valuemax` -- the maximum value of the progress range

## References

- WAI-ARIA Meter Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/meter/
- MDN `role="Progress"`: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Roles/Progress_role
