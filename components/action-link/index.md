# Action Link

An action link is a headless anchor component that visually emphasizes a navigation action, typically appearing as a prominent link that leads the user to a new page or triggers a significant navigation event. Inspired by the NHS England action link pattern, it renders a semantic `<a>` element with optional ARIA label override for screen readers.

Action links are useful when you want to draw attention to a key navigational step, such as "Continue to next step" or "Find a service near you", distinguishing these from standard inline text links.

## Implementation Notes

- Renders as a simple semantic `<a>` element
- Supports `aria-label` override via the `label` prop for when the visible link text is insufficient for screen readers
- Uses `slot` for children content (text, mixed content, etc.)
- Passes through all additional HTML anchor attributes via `...restProps`
- No hardcoded user-facing strings; all text comes through children and props

## Props

- `href`: string (required) -- the URL the link points to
- `label`: string (optional) -- accessible label override for screen readers via aria-label
- `children`: slot (required) -- the link content (text or mixed content)

## Usage

```html
<ActionLink href="/next-step">Continue to next step</ActionLink>
```

## Keyboard Interactions

- Tab: Focus the link (native browser behavior)
- Enter: Activate the link (native browser behavior)

## ARIA

- Implicit `link` role from the `<a>` element
- `aria-label` -- optional override for screen reader text when the visible link text does not fully convey the action

## When to Use

- Use for prominent navigational actions that need visual emphasis, such as "Continue to next step", "Find a service near you", or "Start your application".
- Use when you want to distinguish a key navigation action from standard inline text links.
- Avoid for triggering non-navigation actions like form submission or state changes -- use Button instead.
- Consider BackLink instead when the action is specifically returning to a previous page.

## Headless

This component provides a semantic `<a>` element with optional `aria-label` override and zero visual styling. The consumer is responsible for all CSS including colors, font weight, underline styles, hover effects, focus indicators, and any arrow or icon decoration.

## Advice

- **Designers**: Make action links visually distinct from standard inline links using size, weight, or an arrow icon to signal their importance as key navigational steps.
- **Developers**: Use the `label` prop to provide expanded screen reader text when the visible link text is ambiguous, such as providing "Find a GP near your postcode" for a link that just reads "Find a GP".

## References

- Inspired by NHS England action link pattern
- WAI-ARIA link role: https://www.w3.org/TR/wai-aria-1.2/#link
