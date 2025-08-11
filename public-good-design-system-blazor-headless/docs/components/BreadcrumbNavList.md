# BreadcrumbNavList

A breadcrumb list is an ordered list that contains BreadcrumbNavListItem children, representing the hierarchical trail in a breadcrumb navigation. It renders a semantic `<ol>` element to convey the ordered relationship of pages in the site hierarchy.

Must be placed inside a BreadcrumbNav container, which provides the `<nav>` navigation landmark.

## Implementation Notes

- Renders a semantic `<ol>` element for ordered breadcrumb entries
- Implicit list role allows screen readers to announce item count
- Content is provided through BreadcrumbNavListItem children
- Separator characters (e.g. "/" or ">") between items are the consumer's responsibility
- Compound component: used inside BreadcrumbNav, contains BreadcrumbNavListItem children
- Spreads `AdditionalAttributes` for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
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

None -- passive container. Keyboard interactions are handled by links within BreadcrumbNavListItem children.

## ARIA Attributes

- `<ol>` conveys the ordered hierarchical relationship of the breadcrumb trail
- Implicit list role from semantic `<ol>` element

## References

- WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/
