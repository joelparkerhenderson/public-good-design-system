# BreadcrumbNav

A breadcrumb nav is a navigation landmark that contains a breadcrumb trail showing the user's current location within a site hierarchy. It renders a `<nav>` element with an accessible label and contains a BreadcrumbNavList which holds BreadcrumbNavListItem children.

Breadcrumbs help users understand where they are in the site structure and allow quick navigation back to any ancestor page. They are especially useful in sites with deep hierarchies such as e-commerce catalogs, documentation sites, and content management systems.

## Implementation Notes

- Renders a `<nav>` element for the navigation landmark
- Uses `aria-label` to provide an accessible name
- Compound component: contains BreadcrumbNavList, which contains BreadcrumbNavListItem children
- Spreads `AdditionalAttributes` onto the `<nav>` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<BreadcrumbNav label="Breadcrumb">
  <BreadcrumbNavList>
    <BreadcrumbNavListItem><a href="/">Home</a></BreadcrumbNavListItem>
    <BreadcrumbNavListItem><a href="/products">Products</a></BreadcrumbNavListItem>
    <BreadcrumbNavListItem current>Widget</BreadcrumbNavListItem>
  </BreadcrumbNavList>
</BreadcrumbNav>
```


## Keyboard Interactions

- Tab: Focus moves between links in the breadcrumb trail
- Enter: Activates the focused breadcrumb link

## ARIA Attributes

- `<nav>` with `aria-label` creates a navigation landmark for the breadcrumb trail

## References

- WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/
- HTML nav element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav
