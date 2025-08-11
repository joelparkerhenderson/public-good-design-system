# BreadcrumbList

A breadcrumb list is a navigational component that displays a trail of links representing the user's current location within a site's hierarchy. Breadcrumbs help users understand where they are in the site structure and allow quick navigation back to any ancestor page. They are especially useful in sites with deep hierarchies such as e-commerce catalogs, documentation sites, and content management systems.

BreadcrumbList is a compound component. It provides the parent container structure (a `<nav>` with an `<ol>` inside), while individual breadcrumb entries are rendered using the BreadcrumbListItem component. The parent provides the navigation landmark and the ordered list semantics, and each BreadcrumbListItem renders as an `<li>` with optional `aria-current="page"` for the current page.

## Implementation Notes

- Renders a `<nav>` element for the navigation landmark
- Contains an `<ol>` to convey the ordered hierarchical relationship of the breadcrumb trail
- `aria-label` on the `<nav>` provides an accessible name (e.g. "Breadcrumb")
- Consumer places BreadcrumbListItem components as children
- Separator characters (e.g. "/" or ">") between items should be added by the consumer via CSS or text
- The final item typically uses the `current` prop and contains plain text instead of a link
- Spreads `restProps` onto the `<nav>` for consumer customization
- Uses Svelte 5 `$props()` with TypeScript typing

## Props

- `label`: string (required) -- accessible name for the navigation landmark
- `children`: Snippet (required) -- BreadcrumbListItem components
- `...restProps`: unknown -- additional attributes spread onto the `<nav>` element

## Usage

```svelte
<BreadcrumbList label="Breadcrumb">
  <BreadcrumbListItem><a href="/">Home</a></BreadcrumbListItem>
  <BreadcrumbListItem><a href="/products">Products</a></BreadcrumbListItem>
  <BreadcrumbListItem current>Widget</BreadcrumbListItem>
</BreadcrumbList>
```

## Keyboard Interactions

- Tab: Focus moves between links in the breadcrumb trail
- Enter: Activates the focused breadcrumb link

## ARIA

- `<nav>` with `aria-label` creates a navigation landmark for the breadcrumb trail
- `<ol>` conveys the ordered hierarchical relationship of the trail
- `aria-current="page"` on the BreadcrumbListItem for the current page
- Implicit `listitem` role from semantic `<li>` elements

## References

- WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/
