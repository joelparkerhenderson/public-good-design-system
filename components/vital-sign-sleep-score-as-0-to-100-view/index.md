# Vital Sign Sleep Score As 0 To 100 View

VitalSignSleepScoreAs0To100View is a headless component that renders a read-only display of a sleep score value. The sleep score ranges from 0 to 100, representing overall sleep quality.

Use this component to display a recorded sleep score value in health dashboards, patient records, or wellness tracking interfaces.

## Implementation Notes

- Renders a `<span>` element with `role="img"` for a read-only display
- Uses `aria-label` for an accessible name describing the vital sign and its value
- Stores the numeric value in a `data-value` attribute for programmatic access
- Displays the value as text content within the span

## Props

- `label`: string (required) -- accessible name for the display via `aria-label`
- `value`: number (required) -- the sleep score value (0-100)
- `className`: string (default: `""`) -- CSS class name for the element
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```html
<VitalSignSleepScoreAs0To100View label="Sleep score" value={82} />
```

## Keyboard Interactions

None. This is a read-only display element.

## ARIA

- `role="img"` -- identifies the element as a visual representation of data
- `aria-label={label}` -- provides an accessible name describing the value

## When to Use

- Use to display a recorded sleep score in a read-only context.
- Use in health dashboards, patient summaries, or wellness reports.
- For editable entry, use VitalSignSleepScoreAs0To100Input instead.

## Headless

This headless component renders a `<span>` with `role="img"`, `aria-label`, and `data-value`. The consumer provides all visual styling.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-sleep-score-as-0-to-100-view` class for targeting.

## Testing

- Verify the component renders a `<span>` element with `role="img"`
- Verify `aria-label` is set from the `label` prop
- Verify `data-value` matches the `value` prop
- Verify the value is displayed as text content

## Domain Knowledge

Sleep score is a composite metric (0-100) that represents overall sleep quality, typically derived from sleep duration, efficiency, restfulness, and sleep stages. Higher scores indicate better sleep quality.

## Advice

- **Designers**: Consider color coding to indicate sleep quality ranges (e.g., green for 80+, yellow for 50-79, red for below 50).
- **Developers**: Use the companion VitalSignSleepScoreAs0To100Input for editable data entry.

## References

- MDN span element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/span
