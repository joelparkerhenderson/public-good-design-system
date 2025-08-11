# PaginationNav

A pagination nav is a navigation landmark that contains pagination controls for navigating between pages of content. It renders a `<nav>` element with an accessible label and contains a PaginationList which holds PaginationListItem children.

Pagination helps users navigate large sets of data or information one page at a time. It is commonly used in search results, product listings, data tables, and any interface with paginated content.

Compound component: use with PaginationList and PaginationListItem.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
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


## Keyboard Interactions

- Tab: Focus moves between pagination links in the list
- Enter: Activates the focused link to navigate to that page

## ARIA Attributes

- `<nav>` with `aria-label` creates a navigation landmark for the pagination controls

## References

- WAI-ARIA Navigation role: https://www.w3.org/TR/wai-aria-1.2/#navigation
- HTML nav element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav
