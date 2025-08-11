# Kbd

Kbd is a headless component that renders a `<kbd>` element to display keyboard shortcuts and key combinations in a styled inline element. It semantically marks up user keyboard input.

Use this component to display keyboard shortcuts, key combinations, or individual key references in documentation, tooltips, or help text.

## Implementation Notes

- Renders a native `<kbd>` HTML element for semantic keyboard input markup
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<kbd>` element for consumer customization
- Children slot renders the key label text

## Props

- `className`: string (default: `""`) -- CSS class name for the element
- `children`: slot (required) -- the key label text content
- `...restProps`: unknown -- additional attributes spread onto the `<kbd>` element

## Usage

```html
<Kbd>Ctrl</Kbd> + <Kbd>C</Kbd>
```

```html
Press <Kbd>Enter</Kbd> to submit.
```

## Keyboard Interactions

None. Kbd is a passive display element.

## ARIA

No ARIA attributes needed. The `<kbd>` element has built-in semantics for keyboard input.

## When to Use

- Use to display keyboard shortcuts, key combinations, or key references.
- Use in documentation, help text, tooltips, or command palettes.
- Avoid using for non-keyboard input; use `<code>` for code snippets instead.

## Headless

This headless component renders a `<kbd>` element. The consumer provides all visual styling including borders, backgrounds, padding, border-radius, and font styling to create a keycap appearance.

## Styles

The consumer provides all CSS styling. The component renders with a `.kbd` class for targeting. Common styling includes a keycap appearance with borders, shadows, and monospace font.

## Testing

- Verify the component renders a `<kbd>` element
- Verify children content is rendered
- Verify pass-through attributes are applied

## Advice

- **Designers**: Style Kbd elements to look like physical keycaps with borders, subtle shadows, and rounded corners. Use a monospace font for consistency.
- **Developers**: Nest `<Kbd>` elements for key combinations (e.g., `<Kbd>Ctrl</Kbd> + <Kbd>C</Kbd>`). Use the `<kbd>` semantic for screen readers.

## References

- MDN kbd element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/kbd
