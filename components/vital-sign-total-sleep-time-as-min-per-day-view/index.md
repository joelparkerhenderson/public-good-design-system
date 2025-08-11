# Vital Sign Total Sleep Time As Min Per Day View

VitalSignTotalSleepTimeAsMinPerDayView is a headless component that renders a read-only display of total sleep time in minutes per day. This measures the total duration of sleep within a 24-hour period.

Use this component to display a recorded total sleep time value in health dashboards, patient records, or wellness tracking interfaces.

## Implementation Notes

- Renders a `<span>` element with `role="img"` for a read-only display
- Uses `aria-label` for an accessible name describing the vital sign and its value
- Stores the numeric value in a `data-value` attribute for programmatic access
- Displays the value as text content within the span

## Props

- `label`: string (required) -- accessible name for the display via `aria-label`
- `value`: number (required) -- the total sleep time value in minutes per day
- `className`: string (default: `""`) -- CSS class name for the element
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Usage

```html
<VitalSignTotalSleepTimeAsMinPerDayView label="Total sleep time" value={450} />
```

## Keyboard Interactions

None. This is a read-only display element.

## ARIA

- `role="img"` -- identifies the element as a visual representation of data
- `aria-label={label}` -- provides an accessible name describing the value

## When to Use

- Use to display a recorded total sleep time in a read-only context.
- Use in health dashboards, patient summaries, or wellness reports.
- For editable entry, use VitalSignTotalSleepTimeAsMinPerDayInput instead.

## Headless

This headless component renders a `<span>` with `role="img"`, `aria-label`, and `data-value`. The consumer provides all visual styling.

## Styles

The consumer provides all CSS styling. The component renders with a `.vital-sign-total-sleep-time-as-min-per-day-view` class for targeting.

## Testing

- Verify the component renders a `<span>` element with `role="img"`
- Verify `aria-label` is set from the `label` prop
- Verify `data-value` matches the `value` prop
- Verify the value is displayed as text content

## Domain Knowledge

Total sleep time measures the total duration of sleep within a 24-hour period, measured in minutes. Adults typically need 420-540 minutes (7-9 hours) of sleep per day. Values are typically in the range of 0-1440 minutes (0-24 hours).

## Advice

- **Designers**: Consider displaying the value in both minutes and hours:minutes format (e.g., "450 min (7h 30m)") for readability.
- **Developers**: Use the companion VitalSignTotalSleepTimeAsMinPerDayInput for editable data entry.

## References

- MDN span element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/span
