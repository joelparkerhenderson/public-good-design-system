# Red Orange Yellow Green Blue Picker Button

A five-level color status picker button is an individual button within a RedOrangeYellowGreenBluePicker that represents one of five status levels. When clicked, it selects that status value. The component uses `aria-pressed` to indicate the currently selected state and `data-value` to carry the status value, making it accessible to screen readers and enabling CSS-based styling by status color.

The five levels provide a more granular status scale than the traditional three-level RAG: red indicates critical, orange indicates serious, yellow indicates caution, green indicates good, and blue indicates excellent or informational.

## Implementation Notes

- Renders as a `<button>` element with `aria-pressed` for toggle state
- Designed to be used inside a RedOrangeYellowGreenBluePicker component
- Each button represents one of five status levels (red, orange, yellow, green, blue)
- The `selected` prop controls `aria-pressed` to indicate the active selection
- The `data-value` attribute carries the status value for CSS targeting
- The `label` prop provides the accessible name via `aria-label`
- Spreads `...restProps` onto the `<button>` element for consumer customization

## Props

- `value`: string (required) -- the status value this button represents (e.g., "red", "orange", "yellow", "green", "blue")
- `selected`: boolean (default: false) -- whether this button is currently selected
- `label`: string (required) -- accessible label for the button (e.g., "Red - Critical", "Green - Good")
- `onclick`: callback -- handler called when the button is clicked
- `...restProps`: any -- additional HTML attributes spread onto the `<button>` element

## Usage

```html
<RedOrangeYellowGreenBluePicker label="Risk assessment">
    <RedOrangeYellowGreenBluePickerButton value="red" label="Red - Critical" onclick={handleClick} />
    <RedOrangeYellowGreenBluePickerButton value="orange" label="Orange - Serious" onclick={handleClick} />
    <RedOrangeYellowGreenBluePickerButton value="yellow" label="Yellow - Caution" selected onclick={handleClick} />
    <RedOrangeYellowGreenBluePickerButton value="green" label="Green - Good" onclick={handleClick} />
    <RedOrangeYellowGreenBluePickerButton value="blue" label="Blue - Excellent" onclick={handleClick} />
</RedOrangeYellowGreenBluePicker>
```

## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button to select this status

## ARIA

- `aria-pressed` -- indicates whether this button is the currently selected status (`true` when selected, `false` otherwise)
- `aria-label` -- provides the accessible name for the button (e.g., "Yellow - Caution")
- `data-value` -- carries the status value for CSS-based styling (e.g., `data-value="yellow"`)

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
