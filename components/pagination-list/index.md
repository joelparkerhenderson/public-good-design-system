# Pagination List

A pagination list is a navigation component that divides content into separate pages, allowing users to navigate through large sets of data or information one section at a time. The PaginationList component provides a headless wrapper using the semantic `<nav>` and `<ul>` elements, with an accessible label to identify the navigation purpose.

This component is commonly used in search results, product listings, and data tables where displaying all content at once would be impractical. The consumer provides pagination items (links or buttons) as `<li>` children, and can use `aria-current="page"` to indicate the currently active page.

## Implementation Notes

- Renders a `<nav>` element wrapping a `<ul>` list
- The `<nav>` element uses `aria-label` for identification by assistive technology
- The `label` prop is required to distinguish this navigation from other `<nav>` elements on the page
- Consumer provides `<li>` children containing page links or buttons
- Rest props are spread onto the `<nav>` element
- This is a compound component; see PaginationListItem for individual page items

## Props

- `label`: string (required) -- accessible name for the pagination navigation region via `aria-label`
- `children`: slot (required) -- pagination list items, typically `<li>` elements containing links or buttons
- `...restProps`: unknown -- additional attributes spread onto the `<nav>` element

## Usage

```html
<PaginationList label="Pagination">
  <li><a href="/page/1">1</a></li>
  <li><a href="/page/2" aria-current="page">2</a></li>
  <li><a href="/page/3">3</a></li>
</PaginationList>

<!-- With previous/next controls -->
<PaginationList label="Search results pages">
  <li><a href="/page/1">Previous</a></li>
  <li><a href="/page/1">1</a></li>
  <li><a href="/page/2" aria-current="page">2</a></li>
  <li><a href="/page/3">3</a></li>
  <li><a href="/page/3">Next</a></li>
</PaginationList>
```

## Keyboard Interactions

- Tab: Moves focus between pagination links/buttons in the list
- Enter: Activates the focused link or button to navigate to that page

## ARIA

- `<nav aria-label="...">` -- identifies the pagination as a navigation landmark with a descriptive label
- `aria-current="page"` -- consumer applies this to the link representing the current page

## When to Use

- Use to provide page navigation for large data sets such as search results, product listings, or data tables.
- Use when you need a semantic `<nav>` and `<ul>` structure for pagination links with an accessible label.
- Consider using infinite scrolling or "Load more" patterns instead when pagination would interrupt the user's browsing flow.

## Headless

This headless component provides a `<nav>` wrapping a `<ul>` with `aria-label` for landmark identification and proper list semantics for pagination items. The consumer provides all visual styling, including page link appearance, active-page highlighting, previous/next button styling, and responsive layout.

## Advice

- **Designers**: Highlight the current page clearly and provide previous/next controls. Consider showing ellipsis for large page ranges to keep the pagination compact.
- **Developers**: Apply `aria-current="page"` to the link for the currently active page. Use PaginationListItem for each page entry to maintain consistent markup.

## Composition

PaginationList is part of the PaginationNav compound component. It renders inside PaginationNav and contains PaginationListItem children.

```
PaginationNav → PaginationList (nav + ul) → PaginationListItem (li)
```

## References

- WAI-ARIA Practices - Pagination: https://www.w3.org/WAI/ARIA/apd/patterns/navigation/
- WAI-ARIA navigation role: https://www.w3.org/TR/wai-aria-1.2/#navigation
