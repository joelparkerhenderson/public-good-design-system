# Separator

A separator is a UI/UX component that provides a visual and semantic divider between sections of content. It uses the native HTML `<hr>` element with an explicit `role="separator"` for proper accessibility semantics. An optional label prop can be used to provide additional context about the separation for screen readers.

Separators help organize content into logical groups and improve visual hierarchy without adding unnecessary complexity. They are commonly used between sections of a page, between groups of menu items, or between distinct areas of a form.

## Implementation Notes

- Renders a single `<hr>` element with explicit `role="separator"`
- The `<hr>` element is a void element (no children or closing tag)
- Optional `aria-label` provides descriptive context for screen readers
- Supports rest props via `...restProps` for extensibility (e.g., `id`, `class`)
- The explicit `role="separator"` reinforces the semantic meaning beyond the native `<hr>` role

## Props

- `label`: string (default: undefined) -- optional accessible label describing the separation, applied via `aria-label`
- `...restProps`: spread onto the `<hr>` element

## Usage

```html
<Separator />
```

```html
<Separator label="Section break" />
```

```html
<h2>Introduction</h2>
<p>...</p>
<Separator label="End of introduction" />
<h2>Details</h2>
```

## Keyboard Interactions

None -- this component is a passive container. The `<hr>` element is not focusable and does not receive keyboard input.

## ARIA

- `role="separator"` -- explicitly identifies the element as a separator between sections of content
- `aria-label={label}` -- optional descriptive label for the separator, announced by screen readers when present

## When to Use

- Use to visually and semantically divide distinct sections of content, such as between page sections, form groups, or menu item groups.
- Use when you need assistive technologies to announce a content boundary.
- Avoid using purely for decorative spacing; use CSS margin or padding instead.
- Consider using a heading element instead if the separation also introduces a new topic.

## Headless

This headless component renders a semantic `<hr>` element with an explicit `role="separator"` and optional `aria-label`. It provides the accessible separator semantics and leaves all visual styling -- thickness, color, margin, and orientation -- entirely to the consumer.


## Styles

The consumer provides all CSS styling. The component renders with a `.separator` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<hr>` element with class `separator`
- Verify role="separator"` -- explicitly identifies the element as a separator between sections of content
- Verify aria-label={label}` -- optional descriptive label for the separator, announced by screen readers when present
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use subtle styling that visually distinguishes sections without drawing excessive attention. Maintain consistent separator weight and color throughout the interface.
- **Developers**: Provide an `aria-label` when the purpose of the separation is not obvious from the surrounding content. Avoid nesting separators inside interactive widgets.

## References

- WAI-ARIA Separator Role: https://www.w3.org/TR/wai-aria-1.2/#separator
- MDN hr element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/hr
