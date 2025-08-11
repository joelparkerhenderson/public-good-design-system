# Date Field

A date field provides a fully labeled date input with built-in support for descriptions and error messages. It wraps a native `<input type="date">` with a visible `<label>`, optional helper text, and validation error display, all properly linked via generated IDs for accessibility.

This component is ideal for forms that require date input with validation feedback. The `value` prop is bindable, allowing two-way data flow with the parent component. Error messages are announced to screen readers via `role="alert"`, and the input's invalid state is communicated through `aria-invalid` and `aria-errormessage`.

## Implementation Notes

- Renders a `<div>` wrapper containing a `<label>`, `<input type="date">`, optional description `<p>`, and optional error `<p>`
- Auto-generates a unique ID for the input if none is provided, using derived value for reactivity
- Derives `descriptionId` and `errorId` from the input ID for ARIA linking
- Supports two-way binding on the `value` prop
- Error paragraph uses `role="alert"` for live announcement to screen readers

## Props

- `label`: string (required) -- visible label text for the date field
- `value`: string (default: "") -- current date value in YYYY-MM-DD format, two-way bindable via `value`
- `description`: string (default: undefined) -- helper text displayed below the input
- `error`: string (default: undefined) -- error message displayed when validation fails
- `required`: boolean (default: false) -- whether the field is required
- `disabled`: boolean (default: false) -- whether the field is disabled
- `id`: string (default: undefined) -- custom ID for the input element; auto-generated if omitted

## Usage

```html
<DateField label="Start date" value={value} />
```

```html
<DateField label="End date" value={value} error="Required" required />
```

```html
<DateField label="Birthday" value={value} description="Format: YYYY-MM-DD" />
```

## Keyboard Interactions

None beyond native `<input type="date">` keyboard behavior, which varies by browser.

## ARIA

- `<label for={inputId}>` -- links the visible label to the input
- `aria-describedby={descriptionId}` -- links the input to its description text when present
- `aria-invalid="true"` -- indicates the input contains an invalid value when an error is present
- `aria-errormessage={errorId}` -- links the input to its error message when present
- `role="alert"` -- on the error paragraph, announces the error message to screen readers

## When to Use

- Use a DateField for form date inputs that need a visible label, optional description, and validation error display in a single integrated component.
- Use a DateField when you want built-in ARIA linking between the label, input, description, and error message without manual ID management.
- Avoid using a DateField when you need a bare date input with custom label placement; consider a DateInput instead.

## Headless

This headless DateField component provides a `<div>` wrapper with a `<label>`, `<input type="date">`, optional description `<p>`, and optional error `<p>` with `role="alert"`, all linked by auto-generated IDs for `aria-describedby` and `aria-errormessage`. The consumer provides all visual styling including label typography, input appearance, description and error text colors, and layout.


## Styles

The consumer provides all CSS styling. The component renders with a `.date-field` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `date-field`
- Verify role="alert"` -- on the error paragraph, announces the error message to screen readers
- Verify pass-through attributes are applied

## Advice

- **Designers**: Place the description text below the label and above the input to set expectations before users interact. Display error messages in a contrasting color near the input.
- **Developers**: Use the bindable `value` prop for two-way date state. The auto-generated IDs handle all ARIA linking; provide a custom `id` prop only when you need a specific ID for testing or integration.

## References

- ARIA Error Handling: https://www.w3.org/WAI/WCAG22/Techniques/aria/ARIA21
- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
