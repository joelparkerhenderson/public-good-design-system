# Hint

A hint provides subtle, contextual guidance text associated with a form control. It is typically displayed near an input field to clarify expected formats, explain functionality, or offer examples. The component renders a `<p>` element with an optional `id` for linking to a form control via `aria-describedby`.

This component is designed to work alongside form inputs where the consumer links the hint to the input using `aria-describedby` on the input element pointing to the hint's `id`. This ensures screen readers announce the hint text when the user focuses the associated input.

## Implementation Notes

- Renders a `<p>` element containing the children slot
- Accepts an optional `id` prop for `aria-describedby` linking with form controls
- Spreads `restProps` onto the `<p>` for consumer customization
- The consumer is responsible for adding `aria-describedby` to the associated input

## Props

- `id`: string (default: undefined) -- ID for linking via `aria-describedby` on the associated form control
- `children`: slot (required) -- hint text content

## Usage

```html
<Hint id="email-hint">Enter your work email</Hint>
<input aria-describedby="email-hint" />
```

```html
<Hint id="password-hint">Must be at least 8 characters</Hint>
<input type="password" aria-describedby="password-hint" />
```

## Keyboard Interactions

None -- this component is a passive text element. It is announced by screen readers when the associated form control receives focus.

## ARIA

- `id={id}` -- provides a target for `aria-describedby` on the associated form control

## When to Use

- Use to provide contextual guidance near a form input, such as expected format, examples, or character limits.
- Use when the hint text should be announced by screen readers when the associated input receives focus.
- Avoid for error messages; use ErrorMessage instead. Avoid for lengthy instructions; use InformationCallout instead.

## Headless

This headless component provides a `<p>` element with an optional `id` for linking to a form control via `aria-describedby`. The consumer provides all visual styling including font size, color, spacing, and position relative to the input.


## Styles

The consumer provides all CSS styling. The component renders with a `.hint` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<span>` element with class `hint`
- Verify pass-through attributes are applied

## Advice

- **Designers**: Place hint text directly below the label and above the input. Use a lighter color or smaller font to distinguish it from labels and error messages.
- **Developers**: Always set the `id` prop and add `aria-describedby` to the associated input so screen readers announce the hint when the input is focused.

## References

- WAI Forms Tutorial - Instructions: https://www.w3.org/WAI/tutorials/forms/instructions/
