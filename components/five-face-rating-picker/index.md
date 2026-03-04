# Five Face Rating Input

A five-face rating input allows users to select a rating from 1 to 5 using labeled radio buttons representing faces from "Very bad" to "Very good". This pattern is commonly used in satisfaction surveys, feedback forms, and experience ratings where face-based labels are more intuitive than numeric scales. The component uses radio buttons grouped in a fieldset for proper accessibility and keyboard navigation.

## Implementation Notes

- Renders a `<fieldset>` with `role="radiogroup"` containing 5 `<label>`/`<input type="radio">` pairs
- Supports two-way binding for the selected rating value (1-5, with 0 meaning no selection)
- Default face labels are "Very bad", "Bad", "Okay", "Good", "Very good" -- customizable via the `labels` prop
- Each radio button displays the corresponding label text for screen readers and visual users
- The `name` prop groups the radio buttons for form submission
- Supports `disabled` state on the fieldset level

## Props

- `label`: string (required) -- accessible name for the rating group via `aria-label`
- `value`: number (default: `0`) -- current rating (1-5, 0 = none), two-way bindable via `value`
- `name`: string (default: `"face-rating"`) -- radio group name for form submission
- `labels`: string[] (default: `["Very bad", "Bad", "Okay", "Good", "Very good"]`) -- accessible labels for each face
- `disabled`: boolean (default: `false`) -- whether the entire group is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<fieldset>`

## Usage

```html
<FiveFaceRatingInput label="How was your experience?" value={value} />
```

## Keyboard Interactions

Standard radio group keyboard behavior provided by the browser:

- Tab: focus the selected radio (or first if none selected)
- ArrowDown / ArrowRight: move to next radio button
- ArrowUp / ArrowLeft: move to previous radio button
- Space: select the focused radio button

## ARIA

- `role="radiogroup"` -- on the `<fieldset>`, identifies the group as a set of radio buttons
- `aria-label="..."` -- provides an accessible name for the entire rating group

## When to Use

- Use in satisfaction surveys, feedback forms, or experience ratings where face-based labels are more intuitive than numeric or star scales.
- Use when you need a 1-5 rating with descriptive face labels like "Very bad" through "Very good".
- Avoid for generic numeric ratings; use FiveStarRatingPicker or a RangeInput instead.
- Consider NetPromoterScorePicker for a 0-10 scale survey question.

## Headless

This headless component provides a `<fieldset>` with `role="radiogroup"`, five `<label>`/`<input type="radio">` pairs with customizable face labels, two-way value binding, and `disabled` support. The consumer provides all visual styling, face icons or illustrations, and layout.

## Advice

- **Designers**: Use distinct face illustrations or emoji for each level to make the scale visually intuitive. Ensure the faces are large enough to be easily tapped on touch devices.
- **Developers**: Customize the `labels` prop for internationalization. The `name` prop groups the radio buttons for form submission. Use the `value` binding to track the selected rating.

## Composition

FiveFaceRatingPicker composes with FiveFaceRatingPickerButton using the Picker/PickerButton pattern. The picker provides the group container with `role="radiogroup"`, and each picker button represents one selectable face rating level.

## References

- WAI-ARIA Radio Group Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/radiobutton/
