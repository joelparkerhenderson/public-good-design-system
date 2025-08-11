# Grail Layout Right Aside

GrailLayoutRightAside is a headless container for the right aside section of a GrailLayout. It typically contains supplementary content, ads, related links, or contextual information.

## Implementation Notes

- Renders a `<div>` element for the right aside section
- Spreads `restProps` onto the div for consumer customization
- No styles applied; consumer provides all styling

## Props

- `children`: slot (required) -- content to render inside the right aside
- `...restProps`: unknown -- additional attributes spread onto the `<div>` element

## Usage

```html
<GrailLayoutRightAside>
  <aside>Supplementary content</aside>
</GrailLayoutRightAside>
```


## Styles

The consumer provides all CSS styling. The component renders with a `.grail-layout-right-aside` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<aside>` element with class `grail-layout-right-aside`
- Verify pass-through attributes are applied

## Composition

GrailLayoutRightAside is used as a child of GrailLayout. Place semantic `<aside>` elements inside for proper accessibility.

## References

- CSS Grid Layout: https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_grid_layout
