# Field

A field component wraps a form control with its label, description, and error message, providing proper labelling via `for` attribute linking and accessible error announcements. It serves as a generic form field container that works with any input type -- text inputs, selects, textareas, checkboxes, and more.

The component auto-generates IDs for linking the label to its input and for associating description and error elements via ARIA attributes. A visual required indicator (asterisk) is rendered when `required` is true, hidden from screen readers with `aria-hidden`.

## Implementation Notes

- Renders a `<div>` wrapper containing a `<label>`, consumer-provided children, optional description `<p>`, and optional error `<p>`
- Auto-generates a unique ID using derived value if `inputId` is not provided
- Derives `descId` and `errorId` from the field ID for ARIA linking
- The `<label>` uses `for={fieldId}` to link to the consumer's input element
- Required indicator asterisk uses `aria-hidden="true"` to avoid screen reader noise
- Error paragraph uses `role="alert"` for live announcement
- Sets `data-required` attribute on the wrapper div when `required` is true

## Props

- `label`: string (required) -- visible label text
- `description`: string (default: undefined) -- helper text displayed below the label
- `error`: string (default: undefined) -- error message displayed below the input
- `required`: boolean (default: false) -- whether the field is required, adds a visual asterisk
- `inputId`: string (default: undefined) -- ID of the input to link the label to; auto-generated if omitted
- `children`: slot (required) -- form control (input, select, textarea, etc.)

## Usage

```html
<Field label="Name" description="Enter full name">
  <input id="name-input" />
</Field>
```

```html
<Field label="Email" required error="Email is required">
  <input id="email-input" type="email" />
</Field>
```

## Keyboard Interactions

None -- this component is a passive container. Clicking the label focuses the associated input via the native `for` attribute behavior.

## ARIA

- `<label for={fieldId}>` -- links the visible label to the input element
- `role="alert"` -- on the error paragraph, announces the error message to screen readers
- `aria-hidden="true"` -- on the required asterisk, prevents screen readers from reading the decorative indicator
- `data-required` -- data attribute on the wrapper for consumer CSS styling

## When to Use

- Use to wrap any form control (text input, select, textarea, checkbox) with its label, description, and error message.
- Use when you need automatic ID generation and proper `<label for>` linking without manual wiring.
- Avoid when a form control already has its own label mechanism built in.
- Consider Fieldset when grouping multiple related fields together under a shared legend.

## Headless

This headless component provides a `<div>` wrapper with a `<label>` linked via `for` attribute, optional description and error `<p>` elements with ARIA linking, a required indicator with `aria-hidden`, and `role="alert"` on the error. The consumer provides all visual styling for the label, input, description, error display, and required indicator.


## Styles

The consumer provides all CSS styling. The component renders with a `.field` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `field`
- Verify role="alert"` -- on the error paragraph, announces the error message to screen readers
- Verify pass-through attributes are applied

## Advice

- **Designers**: Position the label above or beside the input consistently across all fields. Use a subtle style for description text and a prominent style for error messages.
- **Developers**: Pass the auto-generated or custom `inputId` to your input component's `id` attribute so the `<label for>` linking works. Use the `error` prop to conditionally show validation messages.

## Composition

Field composes with Label, input components (TextInput, Select, etc.), ErrorMessage, and Hint following the Form/Field/Input pattern. Field wraps a label, the consumer's input, an optional description, and an optional error message. Use inside a Form and group related Fields with Fieldset.

## References

- WAI Forms Tutorial: https://www.w3.org/WAI/tutorials/forms/
- WAI-ARIA Error Handling: https://www.w3.org/WAI/WCAG22/Techniques/aria/ARIA21
