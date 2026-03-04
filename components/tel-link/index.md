# Tel Link

A phone number view displays a phone number as a clickable `tel:` link, allowing users on mobile devices to initiate a phone call directly by tapping or clicking the number. This is part of the Input/View pattern where TelLink is the read-only display counterpart.

The component is useful for contact pages, business listings, user profiles, customer support sections, and any context where a phone number should be displayed as an actionable link rather than plain text.

## Implementation Notes

- Renders an `<a>` element with an `href="tel:{phone}"` attribute for native phone dialing.
- The phone number text is displayed as the link content.
- An optional `label` prop provides an accessible name via `aria-label` when the phone number alone is not descriptive enough (e.g., "Call customer support at +1-555-0100").
- Spreads `restProps` onto the `<a>` element for consumer customization.
- No internal state management; this is a purely presentational component.

## Props

- `phone`: string (required) -- the phone number to display and link to (should include country code, e.g., `"+1-555-0100"`).
- `label`: string (default: `undefined`) -- optional accessible name applied via `aria-label` for additional context.
- `...restProps`: unknown -- additional attributes spread onto the `<a>` element.

## Usage

```html
<TelLink phone="+1-555-0100" />
```

```html
<TelLink phone="+1-555-0100" label="Call customer support" />
```

## Keyboard Interactions

None -- this component uses a native `<a>` element, which provides built-in keyboard support (Tab to focus, Enter to activate the link).

## ARIA

- `aria-label` -- when provided, gives an accessible name that provides more context than the phone number alone (e.g., describing who the number belongs to or its purpose).

## When to Use

- Use to display a phone number as a clickable `tel:` link, enabling one-tap dialing on mobile devices.
- Use on contact pages, business listings, user profiles, and customer support sections where phone numbers should be actionable.
- Avoid when the phone number is editable; use TelInput for form entry instead.
- Consider providing an `aria-label` when the phone number alone does not convey sufficient context.

## Headless

This headless component renders an `<a>` element with `href="tel:{phone}"` and optional `aria-label` for accessibility. It provides native phone dialing link semantics. The consumer provides all visual styling including typography, color, underline treatment, and icon placement.

## Advice

- **Designers**: Style phone links distinctly from other text so users recognize them as actionable. Consider adding a phone icon to reinforce the call-to-action.
- **Developers**: Include the country code in the `phone` prop for reliable international dialing (e.g., "+1-555-0100"). Use the `label` prop to provide context like "Call customer support at +1-555-0100".

## Composition

TelLink and TelInput follow the Input/Link pattern. TelLink provides the read-only clickable `tel:` link for display, while TelInput provides the editable telephone input for forms. Use them together for view and edit modes of phone number data.

## References

- MDN tel: links: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/a#linking_to_telephone_numbers
- WAI-ARIA Link Role: https://www.w3.org/TR/wai-aria-1.2/#link
