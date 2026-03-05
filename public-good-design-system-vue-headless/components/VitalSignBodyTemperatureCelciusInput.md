# VitalSignBodyTemperatureCelciusInput

VitalSignBodyTemperatureCelciusInput is a headless component that wraps a native `<input type="number">` element for entering a body temperature value in degrees Celsius. It provides accessible labelling and sensible default constraints (30-45 °C) with a bindable numeric value for two-way data flow.

This component is useful for medical forms, patient intake screens, health monitoring applications, and any context where body temperature data needs to be entered.

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses `defineModel(undefined)` for two-way binding with an initial undefined state
- Default constraints: `min=30`, `max=45`, `step=0.1`
- Supports `required` and `disabled` boolean states
- Spreads `$attrs` onto the input for consumer customization (e.g., `id`, `name`, `placeholder`)

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current body temperature value; bindable with `v-model`
- `min`: number (default: `30`) -- minimum allowed value
- `max`: number (default: `45`) -- maximum allowed value
- `step`: number (default: `0.1`) -- increment/decrement step size
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...$attrs`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```vue
<VitalSignBodyTemperatureCelciusInput label="Body temperature (°C)" v-model="bodyTemperature" />
```

## Keyboard Interactions

None at the component level. Keyboard behavior is handled natively by the browser's number input implementation (Up/Down arrows to increment/decrement).

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the body temperature input

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role (implicit): https://www.w3.org/TR/wai-aria-1.2/#spinbutton
