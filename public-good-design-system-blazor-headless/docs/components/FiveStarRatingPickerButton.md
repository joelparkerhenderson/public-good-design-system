# FiveStarRatingPickerButton

A button representing one star in a five-star rating picker. Renders a `<button>` with `aria-pressed` to indicate the selected state and `data-value` for consumer CSS targeting.

Compound component: use with FiveStarRatingPicker.

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
<FiveStarRatingPickerButton value=@1 label="1 star" selected={rating === 1} @onclick="HandleClick" />
<FiveStarRatingPickerButton value=@2 label="2 stars" selected={rating === 2} @onclick="HandleClick" />
<FiveStarRatingPickerButton value=@3 label="3 stars" selected={rating === 3} @onclick="HandleClick" />
<FiveStarRatingPickerButton value=@4 label="4 stars" selected={rating === 4} @onclick="HandleClick" />
<FiveStarRatingPickerButton value=@5 label="5 stars" selected={rating === 5} @onclick="HandleClick" />
```



## ARIA Attributes

- `aria-label` -- accessible name for the button
- `aria-pressed` -- indicates whether the star is currently selected
- `data-value` -- exposes the rating value for consumer CSS selectors

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
