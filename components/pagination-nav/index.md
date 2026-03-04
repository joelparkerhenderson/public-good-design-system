# Pagination Nav

A pagination nav is a navigation container for page navigation links, allowing users to move between pages of content such as search results, product listings, or data tables. It renders as a `<nav>` element with an `aria-label`, providing a navigation landmark that can be identified by assistive technologies. The component contains a PaginationList with PaginationListItem children for individual page links.

## Implementation Notes

- Renders as a `<nav>` element to create a navigation landmark for pagination controls
- The `label` prop sets `aria-label` to distinguish this navigation region from other `<nav>` elements on the page
- Consumer provides a PaginationList with PaginationListItem children inside the nav
- Spreads `...restProps` onto the `<nav>` element for consumer customization
- No internal state -- purely a structural wrapper providing the navigation landmark

## Props

- `label`: string (required) -- accessible name for the navigation landmark via `aria-label`
- `children`: slot (required) -- PaginationList with page navigation items
- `...restProps`: any -- additional HTML attributes spread onto the `<nav>` element

## Usage

```html
<PaginationNav label="Pagination">
    <PaginationList>
        <PaginationListItem><a href="/page/1">Previous</a></PaginationListItem>
        <PaginationListItem><a href="/page/1">1</a></PaginationListItem>
        <PaginationListItem><a href="/page/2" aria-current="page">2</a></PaginationListItem>
        <PaginationListItem><a href="/page/3">3</a></PaginationListItem>
        <PaginationListItem><a href="/page/3">Next</a></PaginationListItem>
    </PaginationList>
</PaginationNav>
```

```html
<PaginationNav label="Search results pages">
    <PaginationList>
        <PaginationListItem><a href="/results?page=1">1</a></PaginationListItem>
        <PaginationListItem><a href="/results?page=2" aria-current="page">2</a></PaginationListItem>
        <PaginationListItem><a href="/results?page=3">3</a></PaginationListItem>
    </PaginationList>
</PaginationNav>
```

## Keyboard Interactions

- Tab: Moves focus between pagination links within the navigation
- Enter: Activates the focused link to navigate to that page

## ARIA

- `<nav aria-label="...">` -- creates a navigation landmark with a descriptive label for the pagination region
- Consumer applies `aria-current="page"` on the link representing the current page

## References

- WAI-ARIA Navigation Role: https://www.w3.org/TR/wai-aria-1.2/#navigation
- WAI-ARIA Practices - Navigation: https://www.w3.org/WAI/ARIA/apd/patterns/navigation/
