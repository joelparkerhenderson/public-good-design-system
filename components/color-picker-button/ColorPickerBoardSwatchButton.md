# ColorPicker

A color picker swatch is a button representing a single predefined color choice within a color picker interface. It allows users to select a color from a set of predefined options by clicking on a visually representative swatch. The component communicates selected state through `aria-pressed` and exposes `data-color` for consumer CSS targeting.

This component is useful in color palette UIs, theme builders, product customization forms, and any interface where users choose from a fixed set of color options. Each swatch is a fully accessible button that screen readers can announce by its label and selection state.

## Implementation Notes

- Renders a `<button>` element with `type="button"` to prevent form submission
- Uses inline `style:background-color` to display the color visually
- Exposes `data-color` attribute for consumer CSS selectors (e.g., styling based on selected color)
- Uses `aria-pressed` to communicate toggle/selected state to assistive technology
- Supports `disabled` state for unavailable color options
- Spreads `restProps` for consumer customization

## Props

- `color`: string (required) -- CSS color value applied as background-color and exposed via `data-color`
- `label`: string (required) -- accessible name announced by screen readers (e.g., "Red", "Ocean Blue")
- `selected`: boolean (default: `false`) -- whether the swatch is currently selected, reflected in `aria-pressed`
- `disabled`: boolean (default: `false`) -- whether the swatch is disabled
- `onclick`: `(event: MouseEvent) => void` (default: `undefined`) -- click handler for selection
- `...restProps`: any additional HTML attributes spread onto the button

## Usage

```svelte
<ColorPicker color="#ff0000" label="Red" onclick={handleSelect} />
```

```svelte
<ColorPicker color="#0066cc" label="Blue" selected={true} onclick={handleSelect} />
```

```svelte
<ColorPicker color="#cccccc" label="Gray" disabled={true} />
```

## Keyboard Interactions

- **Tab**: Moves focus to the swatch button
- **Enter / Space**: Activates the button (native button behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name for the swatch since it has no visible text content
- `aria-pressed={selected}` -- indicates whether the swatch is currently selected in a toggle context

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
