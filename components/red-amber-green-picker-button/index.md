# Red Amber Green Picker Button

A RAG (Red/Amber/Green) picker button is an individual button within a RedAmberGreenPicker that represents one traffic-light status level. When clicked, it selects that RAG status value. The component uses `aria-pressed` to indicate the currently selected state and `data-value` to carry the status value, making it accessible to screen readers and enabling CSS-based styling by status color.

Red indicates a critical problem needing immediate attention, amber signals caution or minor issues, and green means everything is on track.

## Implementation Notes

- Renders as a `<button>` element with `aria-pressed` for toggle state
- Designed to be used inside a RedAmberGreenPicker component
- Each button represents one of three RAG status levels (red, amber, green)
- The `selected` prop controls `aria-pressed` to indicate the active selection
- The `data-value` attribute carries the status value for CSS targeting
- The `label` prop provides the accessible name via `aria-label`
- Spreads `...restProps` onto the `<button>` element for consumer customization

## Props

- `value`: string (required) -- the RAG status value this button represents (e.g., "red", "amber", "green")
- `selected`: boolean (default: false) -- whether this button is currently selected
- `label`: string (required) -- accessible label for the button (e.g., "Red - Critical", "Amber - Caution", "Green - On track")
- `onclick`: callback -- handler called when the button is clicked
- `...restProps`: any -- additional HTML attributes spread onto the `<button>` element

## Usage

```html
<RedAmberGreenPicker label="Project status">
    <RedAmberGreenPickerButton value="red" label="Red - Critical" onclick={handleClick} />
    <RedAmberGreenPickerButton value="amber" label="Amber - Caution" selected onclick={handleClick} />
    <RedAmberGreenPickerButton value="green" label="Green - On track" onclick={handleClick} />
</RedAmberGreenPicker>
```

## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button to select this status

## ARIA

- `aria-pressed` -- indicates whether this button is the currently selected status (`true` when selected, `false` otherwise)
- `aria-label` -- provides the accessible name for the button (e.g., "Amber - Caution")
- `data-value` -- carries the status value for CSS-based styling (e.g., `data-value="red"`)

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
- RAG Status: https://en.wikipedia.org/wiki/Traffic_light_rating_system
