# Date Range

A date range is a component that provides paired start and end date inputs, allowing users to specify a span of time. Commonly used in booking forms, search filters, reporting interfaces, and scheduling tools, the date range component groups two date inputs together with a shared label to communicate that they represent a related pair.

This headless component renders a `<fieldset>` containing two native `<input type="date">` elements, each with its own accessible label. Both the start and end values support two-way binding for reactive state management.

## Implementation Notes

- Renders a `<fieldset>` to semantically group the paired date inputs
- Uses two native `<input type="date">` elements for built-in browser date selection
- Both `start` and `end` use two-way binding
- Each input has its own `aria-label` for individual identification
- Accepts `...restProps` for forwarding additional attributes to the fieldset

## Props

- `label`: string (required) -- accessible group label applied to the fieldset via `aria-label`
- `startLabel`: string (required) -- accessible label for the start date input
- `endLabel`: string (required) -- accessible label for the end date input
- `start`: string (default: "") -- start date value in YYYY-MM-DD format; bindable
- `end`: string (default: "") -- end date value in YYYY-MM-DD format; bindable

## Usage

```html
<DateRange
    label="Trip dates"
    startLabel="Departure"
    endLabel="Return"
    start={start}
    end={end}
/>
```

## Keyboard Interactions

- Tab: Move focus between the start and end date inputs
- Up Arrow / Down Arrow: Increment/decrement the focused date segment
- Left Arrow / Right Arrow: Move between date segments within an input

(These are provided by the native `<input type="date">` elements.)

## ARIA

- `aria-label={label}` on `<fieldset>` -- provides an accessible group name for the date range pair
- `aria-label={startLabel}` on the start input -- identifies the start date field
- `aria-label={endLabel}` on the end input -- identifies the end date field

## When to Use

- Use when users need to specify a start and end date together, such as booking forms, reporting filters, or scheduling tools.
- Use when the two dates are semantically paired and should be grouped under a single label.
- Avoid when only a single date is needed; use DateInput instead.
- Consider CalendarRangePicker instead when users benefit from a visual calendar for selecting the range.

## Headless

This headless component provides a semantic `<fieldset>` grouping two native `<input type="date">` elements with accessible labels and two-way binding. It handles ARIA labeling for both the group and individual inputs. The consumer provides all visual styling, layout, spacing, and any validation indicators.


## Styles

The consumer provides all CSS styling. The component renders with a `.date-range` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<span>` element with class `date-range`
- Verify aria-label={label}` on `<fieldset>` -- provides an accessible group name for the date range pair
- Verify aria-label={startLabel}` on the start input -- identifies the start date field
- Verify aria-label={endLabel}` on the end input -- identifies the end date field
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Clearly indicate which field is the start and which is the end, using visual labels or positioning. Ensure the date inputs are visually grouped so users understand they form a pair.
- **Developers**: Validate that the end date is not before the start date. Use the `min` and `max` attributes on the underlying inputs via `restProps` to constrain selectable ranges.

## References

- MDN input type="date": https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date
- MDN fieldset element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/fieldset
