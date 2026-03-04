# Contents List Item

A contents list item is a single entry within a table of contents or navigation list. It renders as a semantic list item (`<li>`) that typically contains a link to a section of a page or document.

Contents list items are used as children of ordered or unordered lists within a table of contents component. They support nesting for hierarchical document structures where sections contain subsections. The consumer provides the content (usually an anchor link with descriptive text) through the children slot, and can add `aria-current` attributes to indicate the currently active section.

## Implementation Notes

- Renders as a semantic `<li>` element for use in contents/navigation lists
- All content is provided through the children slot (typically links)
- Supports nesting by placing a `<ul>` inside a ContentsListItem
- Should be placed inside a `<ul>` or `<ol>` parent element for valid HTML
- Spreads `...restProps` onto the `<li>` element for consumer customization

## Props

- `children`: slot (required) -- list item content, typically a link or nested list
- `...restProps`: Any additional HTML attributes spread onto the `<li>`

## Usage

```html
<ContentsListItem><a href="#section-1">Introduction</a></ContentsListItem>
<ContentsListItem><a href="#section-2">Methods</a></ContentsListItem>
<ContentsListItem>
  <a href="#section-3">Results</a>
  <ul>
    <ContentsListItem><a href="#section-3a">Data</a></ContentsListItem>
    <ContentsListItem><a href="#section-3b">Analysis</a></ContentsListItem>
  </ul>
</ContentsListItem>
```

## Keyboard Interactions

- None directly -- keyboard interaction is handled by contained links or the parent list

## ARIA

- Semantic `<li>` provides implicit `listitem` role
- Supports `aria-current="page"` or `aria-current="true"` on the `<li>` for indicating the current page in a navigation context

## When to Use

- Use a ContentsListItem for each entry in a table of contents or section navigation list.
- Use a ContentsListItem with nested lists to represent hierarchical document structures with subsections.
- Avoid using a ContentsListItem outside of a ContentsList or `<ol>`/`<ul>` parent; it requires a list container for valid HTML.

## Headless

This headless ContentsListItem component provides a semantic `<li>` element with support for `aria-current` and nesting. The consumer provides all visual styling including link appearance, active-section highlighting, indentation for nested items, and hover/focus states.

## Advice

- **Designers**: Highlight the currently active section link to help users orient themselves on long pages. Use consistent indentation for nested subsections.
- **Developers**: Set `aria-current="true"` on the active item to communicate the current section to screen readers. Nest a `<ul>` inside a ContentsListItem to create subsection levels.

## Composition

ContentsListItem is the child component in the ContentsNav/ContentsList/ContentsListItem composition pattern. Place ContentsListItem components inside a ContentsList. Each item typically contains an anchor link. For hierarchical structures, nest a `<ul>` with additional ContentsListItem components inside a parent item.
