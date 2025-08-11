# Carousel

A carousel is a region component for cycling through a set of slides or content items, such as image galleries, product showcases, or testimonial rotators. It provides the semantic container with appropriate ARIA roledescription so assistive technologies announce it as a carousel.

The consumer is responsible for providing the slide content as children and implementing navigation controls (previous/next buttons, pagination dots, autoplay logic, etc.). This headless approach gives full control over navigation behavior, animation, and layout while ensuring accessibility compliance.

## Implementation Notes

- Renders a `<div>` with `role="region"` and `aria-roledescription="carousel"` to communicate the carousel pattern to screen readers.
- The `aria-label` prop provides an accessible name for the region.
- Slide content is passed via the `children` slot, allowing any markup structure.
- Spreads `restProps` onto the container for consumer customization.
- No internal state management for active slide; consumers manage slide state externally.

## Props

- `label`: string (required) -- accessible name for the carousel region, applied via `aria-label`.
- `children`: slot (required) -- slide content to render inside the carousel container.
- `...restProps`: unknown -- additional attributes spread onto the container `<div>`.

## Usage

```html
<Carousel label="Photo gallery">
    <div role="group" aria-label="Slide 1">...</div>
</Carousel>
```

```html
<Carousel label="Featured products">
    {#each slides as slide, i}
        <div role="group" aria-roledescription="slide" aria-label="Slide {i + 1} of {slides.length}">
            {slide.content}
        </div>
    {/each}
</Carousel>
```

## Keyboard Interactions

None -- this component is a passive container. The consumer should implement keyboard navigation for slide controls (e.g., previous/next buttons respond to Enter and Space, arrow keys for slide navigation).

## ARIA

- `role="region"` -- identifies the carousel as a landmark region so screen readers can navigate to it.
- `aria-roledescription="carousel"` -- overrides the default "region" announcement with "carousel" for clearer context.
- `aria-label` -- provides an accessible name describing the carousel content.

## When to Use

- Use a carousel for cycling through a set of related content items such as image galleries, product showcases, or testimonials.
- Use a carousel when horizontal space is limited and users benefit from browsing items one at a time.
- Avoid using a carousel for critical content that all users must see; important information may be missed in later slides.
- Consider a static grid or list layout instead when users need to compare all items simultaneously.

## Headless

This headless Carousel component provides the semantic container with `role="region"`, `aria-roledescription="carousel"`, and `aria-label` for screen reader identification. The consumer provides all visual styling, slide navigation controls (previous/next buttons, pagination dots), autoplay logic, transition animations, and slide layout.


## Styles

The consumer provides all CSS styling. The component renders with a `.carousel` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `carousel`
- Verify role="region"` -- identifies the carousel as a landmark region so screen readers can navigate to it.
- Verify aria-label` -- provides an accessible name describing the carousel content.
- Verify pass-through attributes are applied

## Advice

- **Designers**: Provide clear navigation indicators (dots or arrows) so users understand there is more content to view. Avoid autoplay or provide a visible pause control.
- **Developers**: Mark each slide with `role="group"` and `aria-roledescription="slide"` with an `aria-label` indicating position (e.g., "Slide 1 of 5"). Implement keyboard navigation for slide controls.

## References

- WAI-ARIA Carousel Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/carousel/
- WAI-ARIA Authoring Practices Carousel: https://www.w3.org/WAI/tutorials/carousels/
