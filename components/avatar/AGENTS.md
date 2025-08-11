# Avatar

## Metadata

- Component: avatar
- PascalCase: Avatar
- Description: an avatar indicator that shows an avatar image or avatar text
- HTML tag: <div>
- CSS class: .avatar
- Interactive: no

## ARIA

- `role="img"` -- on the outer container, conveying that the entire avatar is an image representation
- `aria-label` -- set from the `alt` prop, providing the accessible name for the avatar
- `aria-hidden="true"` -- on the inner initials `<span>`, preventing duplicate announcements since the outer element already has `aria-label`

## Keyboard

- None -- this is a decorative/informational component, not interactive

## Acceptance Criteria

- [ ] Renders <div> element with class="avatar"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] Keyboard navigation works correctly
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .avatar in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/avatar.html
- WAI-ARIA Img Role: https://www.w3.org/TR/wai-aria-1.2/#img
