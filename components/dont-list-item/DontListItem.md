# DontListItem

A single item within a DontList. Renders a semantic `<li>` element representing one discouraged action or practice to avoid. This component is designed to be placed inside a DontList `<ul>`, providing proper list item semantics for do/don't guidance patterns.

The consumer provides the content through the children snippet. The component is intentionally minimal, serving as a semantic wrapper that can be styled by the consumer.

## Implementation Notes

- Renders as a semantic `<li>` element for use within a DontList `<ul>`
- All content is provided through the children snippet
- Spreads `...restProps` onto the `<li>` element for consumer customization
- Should be placed inside a DontList component for valid HTML

## Props

- `children`: Snippet (required) -- list item content describing a discouraged action
- `...restProps`: Any additional HTML attributes spread onto the `<li>`

## Usage

```svelte
<DontList>
  <DontListItem>Skip alt text</DontListItem>
  <DontListItem>Use only color for meaning</DontListItem>
  <DontListItem>Remove focus indicators</DontListItem>
</DontList>
```

## Keyboard Interactions

- None directly -- standard list item with no interactive behavior

## ARIA

- Semantic `<li>` provides implicit `listitem` role
- Inherits list context from the parent DontList `<ul>`

## References

- MDN li element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
