# DoListItem

A single item within a DoList. Renders a semantic `<li>` element representing one recommended action or best practice. This component is designed to be placed inside a DoList `<ul>`, providing proper list item semantics for do/don't guidance patterns.

The consumer provides the content through the children snippet. The component is intentionally minimal, serving as a semantic wrapper that can be styled by the consumer.

## Implementation Notes

- Renders as a semantic `<li>` element for use within a DoList `<ul>`
- All content is provided through the children snippet
- Spreads `...restProps` onto the `<li>` element for consumer customization
- Should be placed inside a DoList component for valid HTML

## Props

- `children`: Snippet (required) -- list item content describing a recommended action
- `...restProps`: Any additional HTML attributes spread onto the `<li>`

## Usage

```svelte
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

## References

- MDN li element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
