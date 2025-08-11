# Number Input

NumberInput is a headless component that wraps a native `<input type="number">` element with accessible labelling and optional min, max, and step constraints. It provides a bindable numeric value for two-way data flow.

This component is useful for quantity selectors, age inputs, price fields, configuration values, or any form field that accepts numeric input. The native number input provides browser-built-in validation, increment/decrement controls, and appropriate virtual keyboard on mobile devices.

## Implementation Notes

- Renders a native `<input type="number">` element
- Uses `aria-label` for an accessible name describing the input purpose
- The `value` prop uses two-way binding with an initial undefined state
- Supports optional `min`, `max`, and `step` constraints
- Supports `required` and `disabled` boolean states
- Spreads `restProps` onto the input for consumer customization (e.g., `id`, `name`, `placeholder`)
- pattern: `two-way binding` for the value prop

## Props

- `label`: string (required) -- accessible name for the input via `aria-label`
- `value`: number | undefined (default: `undefined`) -- current numeric value; bindable with two-way `value` binding
- `min`: number (optional) -- minimum allowed value
- `max`: number (optional) -- maximum allowed value
- `step`: number (optional) -- increment/decrement step size
- `required`: boolean (default: `false`) -- whether the input is required
- `disabled`: boolean (default: `false`) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element

## Usage

```html
<NumberInput label="Quantity" value={value} min={0} max={100} step={1} />
```

## Keyboard Interactions

None at the component level. Keyboard behavior is handled natively by the browser's number input implementation (Up/Down arrows to increment/decrement).

## ARIA

- `aria-label={label}` -- provides an accessible name describing the purpose of the number input

## When to Use

- Use for form fields that accept numeric values, such as quantity selectors, age inputs, or price fields.
- Use when you need browser-built-in validation, increment/decrement controls, and numeric virtual keyboards on mobile.
- Consider using TextInput with a pattern attribute instead if you need to accept formatted numbers like "1,000" or phone numbers.

## Headless

This headless component wraps a native `<input type="number">` with `aria-label` for accessible naming, two-way bindable value, and optional `min`, `max`, and `step` constraints. The consumer provides all visual styling, including input dimensions, borders, spinner button appearance, and validation error display.


## Styles

The consumer provides all CSS styling. The component renders with a `.number-input` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<input>` element with class `number-input`
- Verify aria-label={label}` -- provides an accessible name describing the purpose of the number input
- Verify pass-through attributes are applied

## Advice

- **Designers**: Clearly indicate the expected range and step size near the input (e.g., "Enter a value between 1 and 100") to reduce input errors.
- **Developers**: Set `min`, `max`, and `step` props to leverage browser-native validation. Be aware that `<input type="number">` returns an empty string for non-numeric input.

## References

- HTML number input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/number
- WAI-ARIA spinbutton role (implicit): https://www.w3.org/TR/wai-aria-1.2/#spinbutton
