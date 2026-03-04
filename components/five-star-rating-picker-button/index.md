# Five Star Rating Picker Button

A five-star rating picker button is an individual button within a FiveStarRatingPicker that represents one star level on a 1-5 scale. When clicked, it selects that star rating value. The component uses `aria-pressed` to indicate the currently selected state, making it accessible to screen readers and keyboard users.

## Implementation Notes

- Renders as a `<button>` element with `aria-pressed` for toggle state
- Designed to be used inside a FiveStarRatingPicker component
- Each button represents one of five star levels (1-5)
- The `selected` prop controls `aria-pressed` to indicate the active selection
- The `label` prop provides the accessible name via `aria-label` (e.g., "1 star", "3 stars")
- Spreads `...restProps` onto the `<button>` element for consumer customization

## Props

- `value`: string (required) -- the star rating value this button represents (e.g., "1", "2", "3", "4", "5")
- `selected`: boolean (default: false) -- whether this button is currently selected
- `label`: string (required) -- accessible label for the button (e.g., "1 star", "2 stars", "5 stars")
- `onclick`: callback -- handler called when the button is clicked
- `...restProps`: any -- additional HTML attributes spread onto the `<button>` element

## Usage

```html
<FiveStarRatingPicker label="Rate this product">
    <FiveStarRatingPickerButton value="1" label="1 star" onclick={handleClick} />
    <FiveStarRatingPickerButton value="2" label="2 stars" onclick={handleClick} />
    <FiveStarRatingPickerButton value="3" label="3 stars" selected onclick={handleClick} />
    <FiveStarRatingPickerButton value="4" label="4 stars" onclick={handleClick} />
    <FiveStarRatingPickerButton value="5" label="5 stars" onclick={handleClick} />
</FiveStarRatingPicker>
```

## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button to select this rating

## ARIA

- `aria-pressed` -- indicates whether this button is the currently selected rating (`true` when selected, `false` otherwise)
- `aria-label` -- provides the accessible name for the button (e.g., "3 stars")

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
