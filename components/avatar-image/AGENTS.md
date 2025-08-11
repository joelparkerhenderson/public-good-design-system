# Avatar Image

## Metadata

- Component: avatar-image
- PascalCase: AvatarImage
- Description: an avatar indicator inside image such as a user photo
- HTML tag: <img>
- CSS class: .avatar-image
- Interactive: no

## ARIA

- Native `<img>` element with `alt` text provides accessible image semantics
- When inside an Avatar, the parent's `aria-label` provides the primary accessible name

## Keyboard

- None -- this is a decorative/informational element, not interactive

## Acceptance Criteria

- [ ] Renders <img> element with class="avatar-image"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .avatar-image in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/avatar-image.html
- HTML img element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/img
- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
