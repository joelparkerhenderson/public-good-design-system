# Caption

A caption component provides supplementary text or explanations alongside images, videos, charts, or other media within an interface. It uses the semantic `<figcaption>` HTML element, which provides an implicit association with a parent `<figure>` element. Captions are commonly used in galleries, product pages, data visualizations, and educational content to clarify or add context to visual elements.

This headless component lets consumers control all visual presentation while ensuring correct semantic structure and accessibility for captioned media.

## Implementation Notes

- Renders as a semantic `<figcaption>` element
- Designed for use within a `<figure>` parent element for proper semantic association
- Can be referenced via `id` and `aria-describedby` from other elements
- Uses `slot` for children content
- Spreads `...restProps` on the root `<figcaption>` element for consumer customization

## Props

- `children`: slot (required) -- the caption text or content to display

## Usage

```html
<Caption>Photo of a sunset over the ocean.</Caption>
<Caption id="chart-caption">Figure 1: Revenue growth over time.</Caption>
```

## Keyboard Interactions

None -- this component is a passive container for descriptive text.

## ARIA

- Implicit semantics from `<figcaption>` -- automatically associated with its parent `<figure>` element, providing an accessible caption without additional ARIA attributes

## When to Use

- Use for providing descriptive text alongside images, videos, charts, or other media elements within a `<figure>` parent.
- Use when you need a semantic association between media content and its explanatory caption.
- Avoid for standalone text that is not associated with a figure or media element -- use a paragraph or heading instead.
- Consider using `aria-describedby` to link the caption to other elements when used outside a `<figure>`.

## Headless

This component provides a semantic `<figcaption>` element with automatic `<figure>` association and zero visual styling. The consumer is responsible for all CSS including font size, font style (e.g., italic), color, alignment, spacing relative to the media, and any border or background treatment.


## Styles

The consumer provides all CSS styling. The component renders with a `.caption` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<caption>` element with class `caption`
- Verify pass-through attributes are applied

## Advice

- **Designers**: Place captions directly below the media element. Use a smaller font size and muted color to establish visual hierarchy. Keep captions concise.
- **Developers**: Always place this component inside a `<figure>` element for proper semantic association. Use the `id` attribute if you need to reference the caption via `aria-describedby` from other elements.
