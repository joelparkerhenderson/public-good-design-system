# Avatar Text

## Metadata

- Component: avatar-text
- PascalCase: AvatarText
- Description: an avatar indicator inner text such as a user name
- HTML tag: <span>
- CSS class: .avatar-text
- Interactive: no

## ARIA

- Typically marked `aria-hidden="true"` when inside an Avatar, since the parent's `aria-label` already provides the accessible name
- When used standalone, ensure the text is accessible or the parent provides an accessible label

## Keyboard

- None -- this is a decorative/informational element, not interactive

## Acceptance Criteria

- [ ] Renders <span> element with class="avatar-text"
- [ ] Has aria-label attribute
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .avatar-text in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/avatar-text.html
- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
