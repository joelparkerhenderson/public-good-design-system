# Card

A card groups related content and actions into a self-contained semantic container, making it easy to browse and compare items. Cards are commonly used for product listings, user profiles, article previews, media galleries, and dashboard widgets. They present a digestible summary of information that can include headings, text, and interactive elements.

The component renders as an `<article>` element for standalone content grouping. It supports a configurable heading level (h2-h6) for proper document outline, and the heading can optionally be wrapped in a link when an `href` is provided. An optional `aria-label` enables the article to be identified as a named landmark.

## Implementation Notes

- Uses `<article>` for semantic standalone content grouping
- Heading level is configurable (2-6) for proper document outline structure
- When `href` is provided, the heading text wraps in an `<a>` element for navigation
- Optional `aria-label` for named landmark identification
- Content is provided through child elements
- Passes through all additional HTML attributes via `...restProps`

## Props

- `heading`: string (optional) -- heading text for the card
- `headingLevel`: 2 | 3 | 4 | 5 | 6 (default: 3) -- HTML heading level
- `href`: string (optional) -- makes the heading a link
- `label`: string (optional) -- `aria-label` for the article
- `children`: slot (required) -- card body content
- `...restProps`: Any additional HTML attributes passed to the `<article>` element

## Usage

```html
<Card><h3>Title</h3><p>Content</p></Card>
<Card heading="Product" href="/products/1"><p>Description</p></Card>
```

## Keyboard Interactions

- Tab: Focus the heading link when `href` is provided
- Enter: Activate the heading link (browser default)

## ARIA

- Implicit `article` role from the `<article>` element
- Optional `aria-label` -- identifies the card as a named landmark for screen readers

## When to Use

- Use a card to group related content such as a product listing, user profile, or article preview into a scannable unit.
- Use a card when users need to browse and compare multiple items displayed in a grid or list layout.
- Avoid using a card for single full-width content sections; consider a Panel or section element instead.
- Consider a CareCard instead when displaying medical guidance with urgency levels.

## Headless

This headless Card component provides the semantic `<article>` element, configurable heading level for document outline, optional heading link via `href`, and `aria-label` for landmark identification. The consumer provides all visual styling including card borders, shadows, spacing, background colors, and layout of header, body, and footer areas.


## Styles

The consumer provides all CSS styling. The component renders with a `.card` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `card`
- Verify Optional `aria-label` -- identifies the card as a named landmark for screen readers
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Keep card content concise and scannable. Use consistent card heights within a grid to maintain visual rhythm.
- **Developers**: Choose the heading level carefully to preserve the document outline hierarchy. Use the `label` prop when multiple cards appear on one page to help screen reader users distinguish between them.

## Composition

Card supports header, body, and footer content areas through its children slot. Structure the card content with a heading for the header area, paragraph or descriptive content for the body, and action links or buttons for the footer. The `heading` prop provides a built-in heading element, or consumers can supply their own heading as part of the children content.
