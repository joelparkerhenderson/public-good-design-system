# Accordion Nav List Item

## Metadata

- Component: accordion-nav-list-item
- PascalCase: AccordionNavListItem
- Description: one accordion nav list item component
- HTML tag: <li>
- CSS class: .accordion-nav-list-item
- Interactive: yes

## Composition

- Pattern: Nav/List/ListItem
- Parent: accordion-nav-list

## ARIA

- Native `<details>` / `<summary>` provide implicit disclosure widget semantics
- Browser automatically manages expanded/collapsed state announcement

## Keyboard

- Tab: Focus the summary element
- Enter / Space: Toggle open/close (browser default for `<details>`)

## Acceptance Criteria

- [ ] Renders <li> element with class="accordion-nav-list-item"
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .accordion-nav-list-item in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/accordion-nav-list-item.html
- HTML details element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
