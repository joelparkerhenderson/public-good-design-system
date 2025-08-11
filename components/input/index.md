# Input

An input provides a headless text input field with accessible labeling and two-way value binding. It serves as the foundational form input component for text entry, supporting various HTML input types such as text, email, password, number, search, and more.

The component supports bindable value state, required and disabled attributes, and spreads additional props for full consumer control over the native `<input>` element.

## Implementation Notes

- Renders a single `<input>` element with the specified `type` attribute.
- Uses `aria-label` for accessible naming since there is no built-in visible `<label>` element.
- The `value` prop uses two-way binding of the input text.
- The `type` prop defaults to `"text"` but accepts any valid HTML input type string.
- Supports native `required` and `disabled` attributes.
- Spreads `restProps` onto the `<input>` for consumer customization (e.g., `placeholder`, `maxlength`, `pattern`).

## Props

- `label`: string (required) -- accessible name applied via `aria-label`.
- `value`: string (default: `""`) -- bindable current input value.
- `type`: string (default: `"text"`) -- HTML input type attribute (e.g., `"text"`, `"email"`, `"password"`, `"number"`).
- `required`: boolean (default: `false`) -- whether the input is required for form submission.
- `disabled`: boolean (default: `false`) -- whether the input is disabled.
- `...restProps`: unknown -- additional attributes spread onto the `<input>` element.

## Usage

```html
<Input label="Search" value={value} />
```

```html
<Input label="Name" value={value} type="text" required />
```

```html
<Input label="Email address" value={value} type="email" required disabled={isSubmitting} />
```

## Keyboard Interactions

None -- this component uses the native `<input>` element, which provides built-in keyboard support (Tab to focus, standard text editing keys).

## ARIA

- `aria-label` -- provides an accessible name for the input when no visible label is present.

## When to Use

- Use as the foundational text entry component for forms, supporting text, email, password, number, search, and other HTML input types.
- Use when you need a simple, single-line input with accessible labeling and two-way value binding.
- Avoid for multi-line text entry; use Textarea instead. Consider specialized inputs (EmailInput, SearchInput, etc.) for type-specific features.

## Headless

This headless component provides a native `<input>` element with `aria-label`, two-way value binding, and support for `required` and `disabled` attributes. The consumer provides all visual styling including borders, padding, focus states, and placeholder text appearance.


## Styles

The consumer provides all CSS styling. The component renders with a `.input` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<input>` element with class `input`
- Verify aria-label` -- provides an accessible name for the input when no visible label is present.
- Verify pass-through attributes are applied

## Advice

- **Designers**: Ensure input fields have visible focus indicators and sufficient padding. Use consistent sizing across related form fields.
- **Developers**: Prefer specialized input components (EmailInput, TelInput, etc.) when available, as they provide type-specific defaults. Use the `type` prop to leverage browser-native validation and mobile keyboard optimization.

## References

- MDN Input element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/input
- WAI-ARIA Forms: https://www.w3.org/WAI/tutorials/forms/
