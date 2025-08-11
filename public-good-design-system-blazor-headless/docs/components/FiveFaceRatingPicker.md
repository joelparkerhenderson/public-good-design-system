# FiveFaceRatingPicker

A five-face rating picker allows users to select a satisfaction level from 1 to 5 using labeled radio buttons representing faces from "Very bad" to "Very good". This pattern is commonly used in satisfaction surveys, feedback forms, and experience ratings where face-based labels are more intuitive than numeric scales. The component uses radio buttons grouped in a fieldset for proper accessibility and keyboard navigation.

## Implementation Notes

- Renders a `<fieldset>` with `role="radiogroup"` containing 5 `<label>`/`<input type="radio">` pairs
- Uses `@bind-` for the selected rating value (1-5, with 0 meaning no selection)
- Default face labels are "Very bad", "Bad", "Okay", "Good", "Very good" -- customizable via the `labels` prop
- Each radio button displays the corresponding label text for both screen readers and visual users
- The `name` prop groups the radio buttons for form submission
- Supports `disabled` state on the fieldset level
- Additional attributes spread onto the `<fieldset>` via `AdditionalAttributes`

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `int` | `—` | The value value |
| `ValueChanged` | `EventCallback<int>` | `—` | Event callback for two-way binding of Value |
| `Name` | `string?` | `face-rating` | The name value |
| `Disabled` | `bool` | `—` | Whether the component is disabled |

## Usage


```razor
<!-- Basic face rating with two-way binding -->
<FiveFaceRatingPicker label="How was your experience?" @bind-Value />

<!-- Custom face labels for localization or different scales -->
<FiveFaceRatingPicker label="Rate service" @bind-Value labels={["Terrible", "Poor", "Fair", "Great", "Excellent"]} />

<!-- Disabled face rating -->
<FiveFaceRatingPicker label="Previous rating" value=@4 disabled />

<!-- Custom name for form submission -->
<FiveFaceRatingPicker label="Satisfaction" @bind-Value name="satisfaction" />
```


## Keyboard Interactions

Standard radio group keyboard behavior provided by the browser:

- Tab: focus the selected radio (or first if none selected)
- ArrowDown / ArrowRight: move to next radio button
- ArrowUp / ArrowLeft: move to previous radio button
- Space: select the focused radio button

## ARIA Attributes

- `role="radiogroup"` -- on the `<fieldset>`, identifies the group as a set of radio buttons
- `aria-label="..."` -- provides an accessible name for the entire rating group

## References

- WAI-ARIA Radio Group Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/radiobutton/
