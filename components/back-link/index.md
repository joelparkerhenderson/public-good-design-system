# Back Link

A back link is a navigational component that allows users to return to a previous page or step within an application. It renders as a semantic anchor (`<a>`) element with optional `aria-label` for enhanced screen reader context.

Back links are especially important in mobile and multi-step interfaces, helping users maintain their sense of orientation and providing a clear, intuitive way to reverse navigation without relying solely on the browser's back button. Consumers add visual indicators (left arrow, chevron) via CSS or children content.

## Implementation Notes

- Renders as a semantic `<a>` element for backward navigation
- Same HTML pattern as a standard link but semantically represents "going back"
- Supports an optional `aria-label` override for more descriptive screen reader text
- All link text is provided through the children slot
- Spreads `...restProps` onto the `<a>` element

## Props

- `href`: string (required) -- the URL to navigate back to
- `label`: string (optional, default: undefined) -- accessible label override via `aria-label`
- `children`: slot (required) -- the link text/content
- `...restProps`: Any additional HTML attributes spread onto the `<a>`

## Usage

```html
<BackLink href="/previous-page">Back to previous page</BackLink>
<BackLink href="/dashboard" label="Return to dashboard">Back</BackLink>
```

## Keyboard Interactions

- Tab: Focus the link
- Enter: Activate the link (browser default)

## ARIA

- Implicit `link` role from the `<a>` element
- `aria-label` -- optional override for descriptive screen reader text, set from the `label` prop

## When to Use

- Use at the top of a page or multi-step flow to provide a clear "back" navigation action, especially in mobile and wizard-style interfaces.
- Use when users need an explicit way to return to the previous page without relying on the browser back button.
- Avoid for general page navigation -- use standard links or NavigationMenu instead.
- Consider BreadcrumbNav instead when the user needs to see and navigate the full hierarchy.

## Headless

This component provides a semantic `<a>` element with optional `aria-label` override and zero visual styling. The consumer is responsible for all CSS including left-arrow or chevron icons, link color, underline style, hover effects, and focus indicators.


## Styles

The consumer provides all CSS styling. The component renders with a `.back-link` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<a>` element with class `back-link`
- Verify aria-label` -- optional override for descriptive screen reader text, set from the `label` prop
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Place the back link consistently at the top-left of the content area. Include a left-pointing arrow icon to visually reinforce the "back" direction.
- **Developers**: Use the `label` prop to provide descriptive screen reader text when the visible text is short (e.g., "Back" visible but "Return to dashboard" announced).
