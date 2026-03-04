# Datetime Local Input

A datetime-local input allows users to select both a date and time using the native `<input type="datetime-local">` element. It provides accessible labelling via `aria-label` and a bindable value for reactive form state.

This component is useful for scheduling interfaces, event creation forms, appointment booking, and any scenario where both date and time must be captured in a single field. The value follows the format `YYYY-MM-DDThh:mm`, and the browser provides the native date-time picker UI.

## Implementation Notes

- Renders a single `<input type="datetime-local">` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Supports two-way binding on the `value` prop
- The browser provides the native datetime picker UI
- Spreads `restProps` onto the input element for consumer extensibility

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- bindable datetime string (format: YYYY-MM-DDThh:mm)
- `min`: string (default: undefined) -- minimum allowed datetime
- `max`: string (default: undefined) -- maximum allowed datetime
- `required`: boolean (default: false) -- whether the input is required for form submission
- `disabled`: boolean (default: false) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the input element

## Usage

```html
<DatetimeLocalInput label="Event start" value={value} />
```

```html
<DatetimeLocalInput label="Appointment" value={value} min="2024-01-01T08:00" max="2024-12-31T18:00" />
```

```html
<DatetimeLocalInput label="Departure time" value={value} required disabled={isLocked} />
```

## Keyboard Interactions

- Tab: Moves focus to and from the datetime input (native browser behavior)
- Arrow keys: Navigate within the datetime picker fields (native browser behavior)
- Enter: Opens or confirms the datetime picker (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name for the datetime input since there is no visible `<label>` element

## When to Use

- Use when both a date and a time must be captured in a single field, such as scheduling events, booking appointments, or setting deadlines.
- Use when the time zone is not relevant or is handled separately.
- Avoid when only a date is needed; use DateInput instead.
- Consider separate DateInput and TimeInput components when the date and time should be independently editable.

## Headless

This headless component provides a native `<input type="datetime-local">` with accessible labeling via `aria-label`, two-way value binding, and standard form attributes. The browser supplies the native datetime picker UI. The consumer provides all visual styling, layout, and any custom validation feedback.

## Advice

- **Designers**: Place the datetime input near contextual information (e.g., time zone indicator) so users understand the expected format. Ensure sufficient width for the native picker to display properly.
- **Developers**: Use the `min` and `max` props to constrain selectable datetimes. Remember that the value format is `YYYY-MM-DDThh:mm`, not a full ISO 8601 string.

## References

- MDN datetime-local input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/datetime-local
