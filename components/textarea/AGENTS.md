# Textarea

## Metadata

- Component: textarea
- PascalCase: Textarea
- Description: a multi-line text input area
- HTML tag: <textarea>
- CSS class: .textarea
- Interactive: yes

## Key Behaviors

- Renders a single `<textarea>` element with no wrapper
- Uses `aria-label` for accessible naming instead of a visible `<label>` element
- Supports two-way binding on the `value` prop
- The `rows` prop controls the visible height of the text area
- Spreads `restProps` onto the textarea element for consumer extensibility

## ARIA

- `aria-label={label}` -- provides an accessible name for the textarea since there is no visible `<label>` element

## Keyboard

- Tab: Moves focus to and from the textarea (native browser behavior)
- All standard text editing keys function normally within the textarea (native browser behavior)
- Enter: Inserts a new line (does not submit forms, unlike single-line inputs)

## Props

- `label`: string (required) -- accessible name applied via `aria-label`
- `value`: string (default: "") -- bindable text content of the textarea
- `rows`: number (default: undefined) -- number of visible text rows (browser default if unset)
- `required`: boolean (default: false) -- whether the textarea is required for form submission
- `disabled`: boolean (default: false) -- whether the textarea is disabled
- `...restProps`: unknown -- additional attributes spread onto the textarea element

## Acceptance Criteria

- [ ] Renders <textarea> element with class="textarea"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .textarea in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/textarea.html
- MDN textarea element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/textarea
