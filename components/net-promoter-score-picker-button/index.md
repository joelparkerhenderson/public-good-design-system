# Net Promoter Score Picker Button

A Net Promoter Score picker button is an individual button within a NetPromoterScorePicker that represents one score value on a 0-10 scale. When clicked, it selects that NPS score. The component uses `aria-pressed` to indicate the currently selected state, making it accessible to screen readers and keyboard users. NPS scores are categorized as Detractors (0-6), Passives (7-8), and Promoters (9-10).

## Implementation Notes

- Renders as a `<button>` element with `aria-pressed` for toggle state
- Designed to be used inside a NetPromoterScorePicker component
- Each button represents one score value from 0 to 10
- The `selected` prop controls `aria-pressed` to indicate the active selection
- The `label` prop provides the accessible name via `aria-label`
- Spreads `...restProps` onto the `<button>` element for consumer customization

## Props

- `value`: string (required) -- the NPS score value this button represents (e.g., "0" through "10")
- `selected`: boolean (default: false) -- whether this button is currently selected
- `label`: string (required) -- accessible label for the button (e.g., "0 - Not at all likely", "10 - Extremely likely")
- `onclick`: callback -- handler called when the button is clicked
- `...restProps`: any -- additional HTML attributes spread onto the `<button>` element

## Usage

```html
<NetPromoterScorePicker label="How likely are you to recommend us?">
    <NetPromoterScorePickerButton value="0" label="0 - Not at all likely" onclick={handleClick} />
    <NetPromoterScorePickerButton value="1" label="1" onclick={handleClick} />
    <NetPromoterScorePickerButton value="2" label="2" onclick={handleClick} />
    <NetPromoterScorePickerButton value="3" label="3" onclick={handleClick} />
    <NetPromoterScorePickerButton value="4" label="4" onclick={handleClick} />
    <NetPromoterScorePickerButton value="5" label="5" onclick={handleClick} />
    <NetPromoterScorePickerButton value="6" label="6" onclick={handleClick} />
    <NetPromoterScorePickerButton value="7" label="7" onclick={handleClick} />
    <NetPromoterScorePickerButton value="8" label="8" selected onclick={handleClick} />
    <NetPromoterScorePickerButton value="9" label="9" onclick={handleClick} />
    <NetPromoterScorePickerButton value="10" label="10 - Extremely likely" onclick={handleClick} />
</NetPromoterScorePicker>
```

## Keyboard Interactions

- Tab: Focus the button
- Enter / Space: Activate the button to select this score

## ARIA

- `aria-pressed` -- indicates whether this button is the currently selected score (`true` when selected, `false` otherwise)
- `aria-label` -- provides the accessible name for the button (e.g., "8")

## When to Use

- Use as an individual score button within a NetPromoterScorePicker to represent one value on the 0-10 NPS scale.
- Use when each score option needs `aria-pressed` toggle semantics and an accessible label.
- Avoid using NetPromoterScorePickerButton outside of a NetPromoterScorePicker; it is designed for that specific context.

## Headless

This headless component renders a `<button>` with `aria-pressed` for toggle state and `aria-label` for accessible naming. The consumer provides all visual styling, including button size, color coding for Detractor/Passive/Promoter ranges, selected-state appearance, and hover effects.

## Advice

- **Designers**: Size buttons consistently so all 11 values (0-10) fit in a row, and use distinct visual treatment for the selected state.
- **Developers**: Set descriptive `label` values for endpoint buttons (e.g., "0 - Not at all likely", "10 - Extremely likely") to give screen reader users context about the scale.

## Composition

NetPromoterScorePickerButton is a child component of NetPromoterScorePicker. The picker provides the container with radiogroup semantics, while each button represents one score value with toggle state.

```
NetPromoterScorePicker → NetPromoterScorePickerButton (value="0" through "10")
```

## References

- WAI-ARIA Button Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/button/
