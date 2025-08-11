# Theme Select Option

## Metadata

- Component: theme-select-option
- PascalCase: ThemeSelectOption
- Description: one option in a theme select dropdown
- HTML tag: <option>
- CSS class: .theme-select-option
- Interactive: yes

## Composition

- Pattern: Select/SelectOption
- Parent: theme-select

## ARIA

- Native `<option>` element provides built-in accessibility semantics
- `disabled` attribute communicates disabled state to assistive technology

## Keyboard

- Arrow Up/Down: Navigates between options within the parent select (native browser behavior)
- Enter/Space: Selects the focused option (native browser behavior)

## Acceptance Criteria

- [ ] Renders <option> element with class="theme-select-option"
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .theme-select-option in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/theme-select-option.html
- MDN option element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/option
- MDN select element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/select
