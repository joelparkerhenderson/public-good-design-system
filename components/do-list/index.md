# Do List

A do list presents recommended actions or best practices as a list of items. It is used in design system documentation, guidelines, and instructional content to clearly communicate what users or developers should do. The list is paired with the DontList component to create do/don't guidance patterns.

This component renders a semantically labeled unordered list with `role="list"` to ensure assistive technology announces it as a list even when CSS may remove default list semantics. The default label is "Do", making it immediately usable without configuration.

## Implementation Notes

- Renders a `<ul>` element with explicit `role="list"` to preserve list semantics
- Uses `aria-label` to provide an accessible name (defaults to "Do")
- Children slot is rendered inside the list; each child should be an `<li>` element
- Label prop has a sensible default but can be overridden for internationalization
- Spreads `restProps` on the `<ul>` element

## Props

- `label`: string (default: `"Do"`) -- accessible name for the list
- `children`: slot (required) -- list items, each should be an `<li>` element
- `...restProps`: any additional HTML attributes spread onto the `<ul>` element

## Usage

```html
<DoList>
    <li>Write clear labels</li>
    <li>Use semantic HTML</li>
</DoList>
```

```html
<DoList label="Recommended">
    <li>Provide alt text for images</li>
    <li>Use sufficient color contrast</li>
    <li>Test with keyboard navigation</li>
</DoList>
```

## Keyboard Interactions

None -- this component is a passive container for list items.

## ARIA

- `role="list"` -- explicitly declares list semantics on the `<ul>`, ensuring assistive technology announces it as a list
- `aria-label={label}` -- provides an accessible name for the list (defaults to "Do")

## When to Use

- Use in design system documentation and guidelines to present recommended actions or best practices.
- Use alongside DontList to create clear do/don't guidance patterns.
- Avoid for general-purpose lists; use a standard `<ul>` or CheckList instead.

## Headless

This headless component provides a `<ul>` with explicit `role="list"` to preserve list semantics even when CSS removes default markers, and `aria-label` for accessible naming. The consumer provides all visual styling, icons, and layout for the list and its items.


## Styles

The consumer provides all CSS styling. The component renders with a `.do-list` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<ol>` element with class `do-list`
- Verify role="list"` -- explicitly declares list semantics on the `<ul>`, ensuring assistive technology announces it as a list
- Verify aria-label={label}` -- provides an accessible name for the list (defaults to "Do")
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use a distinct visual treatment (such as a green check mark or positive color) to differentiate do-list items from dont-list items. Keep items concise and actionable.
- **Developers**: Place DoListItem components as children. Override the `label` prop for internationalization when the default "Do" label is not appropriate.

## Composition

DoList composes with DoListItem using the List/ListItem pattern. DoList renders the `<ul>` container, and each DoListItem renders an `<li>` within it. Pair with DontList and DontListItem for complete do/don't guidance.

## References

- MDN ul element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ul
- WAI list role: https://www.w3.org/WAI/ARIA/apd/roles/list/
