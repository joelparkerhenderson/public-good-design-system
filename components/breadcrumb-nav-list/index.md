# Breadcrumb Nav List

A breadcrumb nav list is an ordered list of breadcrumb navigation items that form a trail showing the user's current location within a site hierarchy. It renders as an `<ol>` element and is designed to be placed inside a BreadcrumbNav component (which provides the parent `<nav>` landmark). Each item in the list is a BreadcrumbNavListItem representing one level in the hierarchy.

Breadcrumb trails help users understand where they are in the site structure and allow quick navigation back to any ancestor page. The ordered list conveys the hierarchical relationship between items, with each item representing a progressively deeper level.

## Implementation Notes

- Renders as an `<ol>` element to convey the ordered hierarchical relationship of the breadcrumb trail
- Designed to be used inside a BreadcrumbNav, which provides the `<nav>` landmark and `aria-label`
- Consumer places BreadcrumbNavListItem components as children
- Separator characters (e.g., "/" or ">") between items should be added by the consumer via CSS or text
- Spreads `...restProps` onto the `<ol>` element for consumer customization

## Props

- `children`: slot (required) -- BreadcrumbNavListItem components forming the breadcrumb trail
- `...restProps`: any -- additional HTML attributes spread onto the `<ol>` element

## Usage

```html
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

## ARIA

- `<ol>` conveys the ordered hierarchical relationship of the breadcrumb trail
- Implicit `list` role from the semantic `<ol>` element
- The parent BreadcrumbNav provides the `<nav>` landmark with `aria-label`

## References

- WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/
