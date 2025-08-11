# Accordion Nav List

## Metadata

- Component: accordion-nav-list
- PascalCase: AccordionNavList
- Description: an ordered list of accordion nav list item components
- HTML tag: <ol>
- CSS class: .accordion-nav-list
- Interactive: no

## Composition

- Pattern: Nav/List/ListItem
- Parent: accordion-nav
- Children: accordion-nav-list-item

## ARIA

- Semantic `<ol>` element provides ordered list semantics for assistive technology
- List structure conveys that the accordion sections are related and ordered

## Acceptance Criteria

- [ ] Renders <ol> element with class="accordion-nav-list"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .accordion-nav-list in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/accordion-nav-list.html
- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
- HTML `<ol>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol
