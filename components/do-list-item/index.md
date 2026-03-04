# Do List Item

A single item within a DoList. Renders a semantic `<li>` element representing one recommended action or best practice. This component is designed to be placed inside a DoList `<ul>`, providing proper list item semantics for do/don't guidance patterns.

The consumer provides the content through the children slot. The component is intentionally minimal, serving as a semantic wrapper that can be styled by the consumer.

## Implementation Notes

- Renders as a semantic `<li>` element for use within a DoList `<ul>`
- All content is provided through the children slot
- Spreads `...restProps` onto the `<li>` element for consumer customization
- Should be placed inside a DoList component for valid HTML

## Props

- `children`: slot (required) -- list item content describing a recommended action
- `...restProps`: Any additional HTML attributes spread onto the `<li>`

## Usage

```html
<DoList>
  <DoListItem>Write clear labels</DoListItem>
  <DoListItem>Use semantic HTML</DoListItem>
  <DoListItem>Provide alt text for images</DoListItem>
</DoList>
```

## Keyboard Interactions

- None directly -- standard list item with no interactive behavior

## ARIA

- Semantic `<li>` provides implicit `listitem` role
- Inherits list context from the parent DoList `<ul>`

## When to Use

- Use as a child of DoList to represent one recommended action or best practice.
- Use when each guidance item needs individual styling or interactive behavior.
- Avoid using outside of a DoList; it is designed to be placed inside a `<ul>` container.

## Headless

This headless component provides a semantic `<li>` element that inherits list context from its parent DoList. It handles proper list item semantics. The consumer provides all visual styling, icons, and content for the individual item.

## Advice

- **Designers**: Keep each item to a single, clear sentence. Use consistent visual markers (e.g., check marks) across all do-list items.
- **Developers**: Always place DoListItem inside a DoList component for valid HTML structure. Use `restProps` to add custom data attributes or event handlers.

## References

- MDN li element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
