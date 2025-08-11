# VitalSignRespiratoryRateAsBreathsPerMinuteInput

VitalSignRespiratoryRateAsBreathsPerMinuteInput is a headless component that wraps a native `<input type="number">` element for entering a respiratory rate value in breaths per minute. It provides accessible labelling and physiologically appropriate default constraints (0-100 breaths per minute).

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop supports controlled component usage with an initial undefined state
- Default `min=0`, `max=100`, `step=1` for typical respiratory rate ranges
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization (e.g., `id`, `name`, `placeholder`)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current respiratory rate value; controlled with `value + onChange`
- `min`: number (default: `0`) -- minimum allowed value
- `max`: number (default: `100`) -- maximum allowed value
- `step`: number (default: `1`) -- increment/decrement step size
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `onChange`: (value: number | undefined) => void (optional) -- callback when value changes
- `className`: string (default: `""`) -- CSS class name
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```tsx
<VitalSignRespiratoryRateAsBreathsPerMinuteInput label="Respiratory rate" value={value} onChange={setValue} />
```

## Keyboard Interactions

None at the component level. Keyboard behavior is handled natively by the browser's number input implementation (Up/Down arrows to increment/decrement).

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the respiratory rate input

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role (implicit): https://www.w3.org/TR/wai-aria-1.2/#spinbutton
