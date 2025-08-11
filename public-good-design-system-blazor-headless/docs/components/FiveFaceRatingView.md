# FiveFaceRatingView

A read-only five-face rating display that shows a text label corresponding to a rating value from 1 to 5. This is the display-only companion to FiveFaceRatingPicker, used for showing previously submitted ratings in summaries, review lists, or dashboard displays.

## Implementation Notes

- Renders a `<span>` with `role="img"` to indicate it represents a visual rating
- Uses `$derived()` to look up the face label from the `labels` array based on the `value`
- Exposes `data-value` attribute for consumer CSS or testing
- Default labels are "Very bad", "Bad", "Okay", "Good", "Very good" -- customizable via the `labels` prop
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `int` | `—` | The value value |
| `Label` | `string` | `—` | Accessible label for the component |

## Usage


```razor
<FiveFaceRatingView value=@4 label="Good rating" />
```


## Keyboard Interactions

None -- this component is a passive, read-only display.

## ARIA Attributes

- `role="img"` -- indicates the span represents a visual/graphic element (the face rating)
- `aria-label="..."` -- provides an accessible description of the rating for screen readers

## References

- WAI-ARIA `img` role: https://www.w3.org/WAI/ARIA/apd/roles/img/
