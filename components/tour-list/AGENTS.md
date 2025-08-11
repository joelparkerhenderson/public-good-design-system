# Tour List

## Metadata

- Component: tour-list
- PascalCase: TourList
- Description: an ordered list of tour guide steps
- HTML tag: <ol>
- CSS class: .tour-list
- Interactive: yes

## Composition

- Pattern: Tour/List/ListItem
- Parent: tour
- Children: tour-list-item

## ARIA

- `role="dialog"` -- identifies the tour overlay as a dialog window
- `aria-modal="true"` -- indicates the dialog is modal and content behind it is inert
- `aria-label={label}` -- provides an accessible name describing the tour
- `tabindex="-1"` -- allows the dialog element to receive focus for keyboard event handling

## Keyboard

- Escape: Closes the tour by setting `active` to false

## Acceptance Criteria

- [ ] Renders <ol> element with class="tour-list"
- [ ] Has aria-label attribute
- [ ] Has role="dialog"
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .tour-list in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/tour-list.html
- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/
