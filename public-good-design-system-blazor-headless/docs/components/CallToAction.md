# CallToAction

A call to action (CTA) is a component designed to prompt users to take a specific action, such as navigating to a page or triggering an operation. CTAs are typically the most prominent interactive element on a page, driving user engagement toward key goals like "Sign Up", "Learn More", or "Buy Now".

This component renders as an `<a>` element when an `href` is provided (for navigation CTAs) or as a `<button>` when no href is given (for action CTAs). This dual-mode approach ensures correct semantic HTML is used for each use case, benefiting both accessibility and SEO.

## Implementation Notes

- Renders as `<a>` when `href` is provided, `<button type="button">` otherwise
- Dual-mode: link for navigation CTAs, button for action CTAs
- `disabled` only applies in button mode (links cannot be disabled natively)
- Optional `aria-label` for screen reader text override when visible text is insufficient
- Content is provided through the Blazor 5 `ChildContent` RenderFragment
- All user-facing text comes through props and children for internationalization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Href` | `string?` | `—` | The href value |
| `Label` | `string?` | `—` | Accessible label for the component |
| `Disabled` | `bool` | `—` | Whether the component is disabled |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<CallToAction href="/signup">Sign Up Now</CallToAction>
<CallToAction @onclick="handleAction">Get Started</CallToAction>
```


## Keyboard Interactions

- Tab: Focus the element
- Enter: Activate the link or button
- Space: Activate the button (button mode only; links do not respond to Space)

## ARIA Attributes

- Implicit `link` role when rendered as `<a>`
- Implicit `button` role when rendered as `<button>`
- Optional `aria-label` -- provides screen reader text when visible text alone is insufficient
