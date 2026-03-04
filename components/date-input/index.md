# Date Input

A date input provides a headless native HTML date input element with accessible labelling via `aria-label`. It is a minimal wrapper for `<input type="date">` that leverages the browser's built-in date picker for date selection.

This component is useful in forms where users need to enter a calendar date. The value is stored in ISO 8601 `YYYY-MM-DD` format. It supports min and max constraints to restrict the allowable date range, and integrates with two-way binding for reactive form state.

## Implementation Notes

- Renders a single `<input type="date">` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Supports two-way binding on the `value` prop
- The browser provides the native date picker UI
- Spreads `restProps` onto the input element for consumer extensibility

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- bindable date string in YYYY-MM-DD format
- `min`: string (default: undefined) -- minimum allowed date in YYYY-MM-DD format
- `max`: string (default: undefined) -- maximum allowed date in YYYY-MM-DD format
- `required`: boolean (default: false) -- whether the input is required for form submission
- `disabled`: boolean (default: false) -- whether the input is disabled
- `...restProps`: unknown -- additional attributes spread onto the input element

## Usage

```html
<DateInput label="Birth date" value={value} />
```

```html
<DateInput label="Deadline" value={value} min="2024-01-01" max="2024-12-31" />
```

```html
<DateInput label="Start date" value={value} required disabled={isLocked} />
```

## Keyboard Interactions

- Tab: Moves focus to and from the date input (native browser behavior)
- Arrow keys: Navigate within the date picker fields (native browser behavior)
- Enter: Opens or confirms the date picker (native browser behavior)

## ARIA

- `aria-label={label}` -- provides an accessible name for the date input since there is no visible `<label>` element

## When to Use

- Use a DateInput for a bare date input with `aria-label` when you need full control over label placement and surrounding layout.
- Use a DateInput in compact forms or table cells where a full DateField with visible label would take too much space.
- Avoid using a DateInput without providing an accessible name; always set the `label` prop. Consider a DateField when you need a visible label and error handling built in.

## Headless

This headless DateInput component provides a native `<input type="date">` with `aria-label` for accessible naming, two-way binding on the `value` prop, and `min`/`max` constraints for date range validation. The consumer provides all visual styling including input appearance, calendar icon, and any surrounding label or helper text.

## Advice

- **Designers**: Ensure the date input is wide enough to display the full date format. Consider showing the expected format (e.g., YYYY-MM-DD) as placeholder or helper text nearby.
- **Developers**: Use ISO 8601 `YYYY-MM-DD` format for `value`, `min`, and `max` props. The browser provides the native date picker UI, which varies across browsers and platforms.

## References

- MDN date input: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input/date
