# Grail Layout Top Header

GrailLayoutTopHeader is a headless container for the top header section of a GrailLayout. It spans the full width of the layout and typically contains site branding, navigation, or a top bar.

## Implementation Notes

- Renders a `<div>` element for the top header section
- Spreads `restProps` onto the div for consumer customization
- No styles applied; consumer provides all styling

## Props

- `children`: slot (required) -- content to render inside the top header section
- `...restProps`: unknown -- additional attributes spread onto the `<div>` element

## Usage

```html
<GrailLayoutTopHeader>
  <header>Site Header</header>
</GrailLayoutTopHeader>
```


## Styles

The consumer provides all CSS styling. The component renders with a `.grail-layout-top-header` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<header>` element with class `grail-layout-top-header`
- Verify pass-through attributes are applied

## Composition

GrailLayoutTopHeader is used as a child of GrailLayout. Place semantic `<header>` or `<nav>` elements inside for proper accessibility.

## References

- CSS Grid Layout: https://developer.mozilla.org/en-US/docs/Web/CSS/CSS_grid_layout
