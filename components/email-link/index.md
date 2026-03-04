# Email Link

An email link displays an email as a clickable mailto link. When clicked, it opens the user's default email client with the address pre-filled. This is the read-only companion to EmailAddressInput, used for displaying email addresses in profiles, contact lists, or user cards.

## Implementation Notes

- Renders an `<a>` element with `href="mailto:{email}"` for native email client integration
- Displays the email address as visible link text
- Supports an optional `aria-label` override for cases where additional context is needed
- Spreads `restProps` for consumer customization

## Props

- `email`: string (required) -- the email address to display and link to
- `label`: string (default: `undefined`) -- optional accessible label override via `aria-label`
- `...restProps`: unknown -- additional attributes spread onto the `<a>` element

## Usage

```html
<EmailAddressView email="alice@example.com" />
```

## Keyboard Interactions

None -- this is a standard `<a>` link; keyboard behavior (Tab to focus, Enter to activate) is provided natively by the browser.

## ARIA

- `aria-label="..."` -- optional override for the accessible name when the visible email text alone is insufficient context

## When to Use

- Use to display an email address as a clickable mailto link in profiles, contact pages, or user cards.
- Use when clicking the email should open the user's default email client.
- Avoid when the email address needs to be editable; use EmailInput instead.
- Consider plain text display when the email should not be interactive.

## Headless

This headless component provides an `<a>` element with `href="mailto:{email}"`, the email address as visible link text, and optional `aria-label` override for additional context. The consumer provides all visual styling for the link appearance.

## Advice

- **Designers**: Style the email link consistently with other hyperlinks in your design system. Consider adding an email icon to visually indicate the mailto behavior.
- **Developers**: Use the `label` prop to provide additional accessible context when the email address alone is ambiguous (e.g., when multiple email links appear on the same page).

## References

- MDN `mailto:` links: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a#linking_to_an_email_address
