# Pagination List Item

A pagination list item represents a single entry within a pagination navigation list. It renders as a semantic `<li>` element designed to be placed inside a PaginationList component (which provides the parent `<nav>` and `<ul>` structure). The item typically contains a link or button for a specific page number, previous/next controls, or an ellipsis indicator.

Consumers are responsible for adding `aria-current="page"` on the active page link and any additional ARIA attributes needed on the child elements.

## Implementation Notes

- Renders as a semantic `<li>` element for use inside a PaginationList `<ul>` / `<nav>` structure
- Content is provided through the children slot, typically a link or button for a page number
- Passes through all additional HTML attributes via `...restProps`
- Uses `slot` for children content

## Props

- `children`: slot (required) -- item content, typically a link (e.g., `<a href="/page/2">2</a>`) or button

## Usage

```html
<PaginationListItem><a href="/page/1">1</a></PaginationListItem>
```

## Keyboard Interactions

None directly -- keyboard interaction is handled by the contained links or buttons.

## ARIA

- Implicit `listitem` role from the semantic `<li>` element
- Consumer should set `aria-current="page"` on the active page link within the item

## When to Use

- Use as an individual page entry within a PaginationList, containing a page link, previous/next control, or ellipsis.
- Use when each pagination item needs semantic `<li>` structure within the parent `<ul>`.
- Avoid using PaginationListItem outside of a PaginationList; it relies on the parent list structure.

## Headless

This headless component renders a semantic `<li>` element with a children slot for page links or buttons. The consumer provides all visual styling, including link appearance, active-page highlighting, and spacing between items.

## Advice

- **Designers**: Ensure each page item has a large enough click/touch target and consistent spacing for easy navigation.
- **Developers**: Place `aria-current="page"` on the link or button within the active page item, not on the `<li>` itself.

## Composition

PaginationListItem is the leaf component in the PaginationNav compound pattern. It is placed inside PaginationList as an `<li>` element.

```
PaginationNav → PaginationList → PaginationListItem (li) → link or button
```
