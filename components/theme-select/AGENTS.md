# Theme Select

## Metadata

- Component: theme-select
- PascalCase: ThemeSelect
- Description: a select dropdown for choosing a theme
- HTML tag: <select>
- CSS class: .theme-select
- Interactive: yes

## Composition

- Pattern: Select/SelectOption
- Children: theme-select-option

## ARIA

- `aria-label={label}` -- provides an accessible name for the theme select since there is no visible `<label>` element

## Keyboard

- Tab: Moves focus to and from the select element (native browser behavior)
- Space/Enter: Opens the dropdown list when focused (native browser behavior)
- Arrow Up/Down: Navigates through theme options (native browser behavior)
- Escape: Closes the dropdown list (native browser behavior)

## Acceptance Criteria

- [ ] Renders <select> element with class="theme-select"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .theme-select in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/theme-select.html
- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
- WCAG 1.4.12 Text Spacing (theme customization): https://www.w3.org/WAI/WCAG22/Understanding/text-spacing.html
