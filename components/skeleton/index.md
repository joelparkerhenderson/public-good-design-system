# Skeleton

A skeleton is a loading placeholder that indicates content is in the process of loading. It shows the approximate layout of content before it loads, reducing perceived loading time and preventing layout shift. The component uses `aria-hidden="true"` to hide the placeholder from screen readers and `aria-busy="true"` to signal that the region is being updated. The component is headless, allowing consumers to style the placeholder shapes with their own CSS.

## Implementation Notes

- Renders a `<div>` with `aria-hidden="true"` so screen readers completely skip the placeholder
- Uses `aria-busy="true"` to signal to assistive technology that the region is loading
- Accepts an optional `children` slot for placeholder shapes (e.g., lines, circles, rectangles)
- Spreads `restProps` for consumer customization (e.g., sizing, data attributes)

## Props

- `children`: slot (default: `undefined`) -- optional placeholder content (e.g., skeleton line shapes)
- `...restProps`: unknown -- additional attributes spread onto the `<div>`

## Usage

```html
<Skeleton />
```

```html
<Skeleton>
  <div class="skeleton-line"></div>
</Skeleton>
```

## Keyboard Interactions

None -- this component is a passive placeholder hidden from interaction.

## ARIA

- `aria-hidden="true"` -- hides the placeholder entirely from screen readers
- `aria-busy="true"` -- signals that this region is in a loading state and content will be replaced

## When to Use

- Use as a placeholder while content is loading to show the approximate layout and reduce perceived wait time.
- Use to prevent layout shift by reserving space for content that has not yet loaded.
- Avoid for very fast operations where a skeleton would flash briefly and be distracting; consider no indicator or a simple spinner instead.
- Consider a ProgressSpinner when the loading state is indeterminate and the content layout is unknown.

## Headless

This headless component provides a `<div>` with `aria-hidden="true"` and `aria-busy="true"` to hide the placeholder from screen readers while signaling a loading state. The consumer provides all visual styling including placeholder shapes, shimmer animations, dimensions, and colors.

## Advice

- **Designers**: Match skeleton shapes to the actual content layout (e.g., rectangles for text lines, circles for avatars). Use a subtle animation such as a shimmer or pulse to indicate loading.
- **Developers**: Replace the skeleton with actual content as soon as data loads, ensuring `aria-busy` is removed from the parent region. Avoid rendering skeletons for content that loads in under 200ms.

## References

- WAI-ARIA `aria-busy`: https://www.w3.org/WAI/ARIA/apd/states/aria-busy/
- MDN `aria-hidden`: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Attributes/aria-hidden
