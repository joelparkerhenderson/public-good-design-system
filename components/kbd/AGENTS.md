# Kbd

## Metadata

- Component: kbd
- PascalCase: Kbd
- Description: show keyboard shortcuts and key combinations in a styled inline element
- HTML tag: <kbd>
- CSS class: .kbd
- Interactive: no

## Key Behaviors

- Renders a native `<kbd>` HTML element for semantic keyboard input markup
- Accepts `className` for CSS class targeting
- Spreads `restProps` onto the `<kbd>` element for consumer customization
- Children slot renders the key label text

## Props

- `className`: string (default: `""`) -- CSS class name for the element
- `children`: slot (required) -- the key label text content
- `...restProps`: unknown -- additional attributes spread onto the `<kbd>` element

## Acceptance Criteria

- [ ] Renders <kbd> element with class="kbd"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .kbd in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/kbd.html
- MDN kbd element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/kbd
