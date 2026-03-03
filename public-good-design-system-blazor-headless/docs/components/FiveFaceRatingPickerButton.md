# FiveFaceRatingPickerButton

A button representing one face in a five-face rating picker. Renders a `<button>` with `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.

Compound component: use with FiveFaceRatingPicker.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Value` | `string` | `—` | The value value |
| `Label` | `string` | `—` | Accessible label for the component |
| `Selected` | `bool` | `—` | The selected value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<FiveFaceRatingPickerButton value=@1 label="Very bad" selected={rating === 1} @onclick="HandleClick" />
<FiveFaceRatingPickerButton value=@2 label="Bad" selected={rating === 2} @onclick="HandleClick" />
<FiveFaceRatingPickerButton value=@3 label="Okay" selected={rating === 3} @onclick="HandleClick" />
<FiveFaceRatingPickerButton value=@4 label="Good" selected={rating === 4} @onclick="HandleClick" />
<FiveFaceRatingPickerButton value=@5 label="Very good" selected={rating === 5} @onclick="HandleClick" />
```



## ARIA Attributes

- `aria-label` -- accessible name for the button
- `aria-pressed` -- indicates whether the face is currently selected
- `data-value` -- exposes the rating value for consumer CSS selectors

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
