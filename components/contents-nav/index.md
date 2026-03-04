# Contents List

A contents list provides a table-of-contents navigation with ordered links to page sections. It helps users quickly scan and jump to different parts of a long page, improving navigation and content discoverability.

This component is commonly used at the top of documentation pages, articles, or forms with multiple sections. It renders a semantic `<nav>` landmark with an ordered list, making the hierarchical structure clear to both visual users and assistive technology. Use ContentsListItem components or `<li>` elements as children.

## Implementation Notes

- Renders a `<nav>` element with `aria-label` for accessible landmark identification
- Contains an `<ol>` (ordered list) to convey the sequential nature of page sections
- Children slot is rendered inside the ordered list
- Label prop is required for accessibility, distinguishing this navigation from others on the page
- Spreads `restProps` on the outer `<nav>` element
- This is a compound component; use with ContentsListItem for individual entries

## Props

- `label`: string (required) -- accessible name for the navigation landmark (e.g., "Contents", "On this page")
- `children`: slot (required) -- list items, typically ContentsListItem components or `<li>` elements with links
- `...restProps`: any additional HTML attributes spread onto the `<nav>` element

## Usage

```html
<ContentsList label="Contents">
    <li><a href="#introduction">Introduction</a></li>
    <li><a href="#usage">Usage</a></li>
    <li><a href="#examples">Examples</a></li>
</ContentsList>
```

## Keyboard Interactions

None -- this component is a passive navigation container. Keyboard navigation is handled natively by the anchor links within list items.

## ARIA

- `aria-label={label}` -- provides an accessible name for the `<nav>` landmark, distinguishing it from other navigation regions on the page

## When to Use

- Use a ContentsNav as the navigation landmark wrapper for a table of contents on long documentation pages or articles.
- Use a ContentsNav to provide a distinct navigation region that screen reader users can quickly jump to via landmark navigation.
- Avoid using a ContentsNav for general page navigation; use NavigationMenu or BreadcrumbNav instead.

## Headless

This headless ContentsNav component provides a semantic `<nav>` element with `aria-label` for landmark identification, containing an `<ol>` for ordered section links. The consumer provides all visual styling including positioning (sticky sidebar or inline), borders, spacing, and link appearance.

## Advice

- **Designers**: Place the contents navigation in a consistent location, such as the top of the content area or a sticky sidebar. Ensure it is visually distinct from the main navigation.
- **Developers**: Set the `label` prop to a descriptive name (e.g., "On this page") to differentiate this landmark from other `<nav>` elements. Use ContentsList and ContentsListItem as children.

## Composition

ContentsNav follows the Nav/List/ListItem composition pattern. Use ContentsNav as the outer `<nav>` landmark, ContentsList as the inner ordered list, and ContentsListItem for each section link entry. This three-level structure ensures proper semantics and landmark navigation for assistive technology users.

## References

- WAI-ARIA Navigation Landmark: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
- MDN nav element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav
