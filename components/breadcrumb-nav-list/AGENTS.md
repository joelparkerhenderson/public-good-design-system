# Breadcrumb Nav List

## Metadata

- Component: breadcrumb-nav-list
- PascalCase: BreadcrumbNavList
- Description: an ordered list of breadcrumb navigation items
- HTML tag: <ol>
- CSS class: .breadcrumb-nav-list
- Interactive: yes

## Composition

- Pattern: Nav/List/ListItem
- Parent: breadcrumb-nav
- Children: breadcrumb-nav-list-item

## Key Behaviors

- Renders as an `<ol>` element to convey the ordered hierarchical relationship of the breadcrumb trail
- Designed to be used inside a BreadcrumbNav, which provides the `<nav>` landmark and `aria-label`
- Consumer places BreadcrumbNavListItem components as children
- Separator characters (e.g., "/" or ">") between items should be added by the consumer via CSS or text
- Spreads `...restProps` onto the `<ol>` element for consumer customization

## ARIA

- `<ol>` conveys the ordered hierarchical relationship of the breadcrumb trail
- Implicit `list` role from the semantic `<ol>` element
- The parent BreadcrumbNav provides the `<nav>` landmark with `aria-label`

## Keyboard

- Tab: Focus moves between links in the breadcrumb trail
- Enter: Activates the focused breadcrumb link

## Props

- `children`: slot (required) -- BreadcrumbNavListItem components forming the breadcrumb trail
- `...restProps`: any -- additional HTML attributes spread onto the `<ol>` element

## Acceptance Criteria

- [ ] Renders <ol> element with class="breadcrumb-nav-list"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .breadcrumb-nav-list in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/breadcrumb-nav-list.html
- WAI-ARIA Breadcrumb Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/breadcrumb/
