# Details

A disclosure widget that reveals or hides additional content on demand. Built on the native HTML `<details>` and `<summary>` elements, this component provides progressive disclosure -- showing only what is necessary upfront and letting users expand sections for more information. Common use cases include FAQs, collapsible sections, advanced options, and supplementary explanations.

The native `<details>` element provides built-in accessibility support without requiring custom ARIA attributes. Screen readers automatically announce the expanded or collapsed state. The component exposes a bindable `open` prop so parent components can programmatically control or react to the disclosure state.

## Implementation Notes

- Renders native `<details>` and `<summary>` HTML elements for built-in browser accessibility
- Supports two-way binding on the `open` prop for two-way state synchronization on the `open` prop
- The `summary` prop provides the clickable toggle text
- Accepts a `children` slot for the expandable content area
- Spreads `restProps` onto the `<details>` element for consumer customization
- Similar to Collapsible but uses a more generic, standards-based API

## Props

- `summary`: string (required) -- text displayed in the summary toggle
- `open`: boolean (default: false) -- whether the details section is expanded; bindable
- `children`: slot (required) -- content revealed when expanded

## Usage

```html
<Details summary="More information">
  <p>Additional details shown when expanded.</p>
</Details>
```

```html
<Details summary="Advanced options" open={showAdvanced}>
  <p>Configure advanced settings here.</p>
</Details>

{#if showAdvanced}
  <p>Advanced options are currently visible.</p>
{/if}
```

## Keyboard Interactions

- Enter or Space: toggles the disclosure open/closed when the `<summary>` element is focused (native browser behavior)

## ARIA

- Native `<details>` and `<summary>` elements provide built-in ARIA semantics
- The browser automatically exposes the expanded/collapsed state to assistive technology
- No additional ARIA attributes are needed because the native elements handle accessibility

## When to Use

- Use for progressive disclosure of supplementary content, such as FAQs, additional explanations, or advanced options.
- Use when content should be hidden by default but available on demand without navigating to another page.
- Avoid for critical information that users must see; do not hide essential content behind a disclosure toggle.
- Consider Expander instead when you need full control over the toggle button behavior beyond native `<details>`.

## Headless

This headless component provides native `<details>` and `<summary>` elements with built-in browser accessibility, including automatic expanded/collapsed state announcements. It supports two-way binding on the `open` prop. The consumer provides all visual styling for the summary toggle and expanded content area.

## Advice

- **Designers**: Make the summary text descriptive enough that users understand what content will be revealed. Use visual cues (such as a chevron icon) to indicate expandability.
- **Developers**: Use the bindable `open` prop to synchronize state with parent components. Avoid nesting multiple levels of Details deeply, as it can create confusing navigation.

## References

- MDN details element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
- MDN summary element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/summary
- WAI-ARIA Disclosure Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/disclosure/
