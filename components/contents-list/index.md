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

- Use a ContentsList at the top of long pages to provide a table of contents with ordered links to page sections.
- Use a ContentsList on documentation pages, articles, or multi-section forms to improve navigation and content discoverability.
- Avoid using a ContentsList on short pages with fewer than three sections; the overhead adds no value.

## Headless

This headless ContentsList component provides a semantic `<nav>` landmark with `aria-label` and an `<ol>` for ordered section links. The consumer provides all visual styling including link appearance, indentation for nested items, active-section highlighting, and sticky positioning.


## Styles

The consumer provides all CSS styling. The component renders with a `.contents-list` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<ol>` element with class `contents-list`
- Verify aria-label={label}` -- provides an accessible name for the `<nav>` landmark, distinguishing it from other navigation regions on the page
- Verify pass-through attributes are applied

## Advice

- **Designers**: Position the contents list prominently at the top of the page or as a sticky sidebar. Use indentation to show section hierarchy.
- **Developers**: Use the `label` prop (e.g., "Contents" or "On this page") to distinguish this navigation from other `<nav>` elements. Populate with ContentsListItem components or `<li>` elements containing anchor links.

## Composition

ContentsList follows the Nav/List/ListItem composition pattern as part of the ContentsNav group. Use ContentsNav as the outer navigation landmark, ContentsList as the ordered list container, and ContentsListItem for each individual section link. ContentsListItem supports nesting for hierarchical section structures.

## References

- WAI-ARIA Navigation Landmark: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
- MDN nav element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav
