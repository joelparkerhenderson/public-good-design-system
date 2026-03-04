# Grail Layout Center Main

GrailLayoutCenterMain is a headless container for the center main content section of a GrailLayout. It holds the primary page content and is flanked by the left and right aside sections.

## Implementation Notes

- Renders a `<div>` element for the center main content section
- Spreads `restProps` onto the div for consumer customization
- No styles applied; consumer provides all styling

## Props

- `children`: slot (required) -- content to render inside the center main section
- `...restProps`: unknown -- additional attributes spread onto the `<div>` element

## Usage

```html
<GrailLayoutCenterMain>
  <main>Primary content</main>
</GrailLayoutCenterMain>
```

## Composition

GrailLayoutCenterMain is used as a child of GrailLayout. Place a semantic `<main>` element inside for proper accessibility.

## References

- CSS Grid Layout: https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_grid_layout
