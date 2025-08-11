# HolyGrailLayout

The Holy Grail layout is a classic web design pattern featuring a header, footer, main content area, and two sidebars. This component provides a minimal wrapper `<div>` that expects consumers to supply semantic HTML landmark elements -- `<header>`, `<nav>`, `<main>`, `<aside>`, and `<footer>` -- as children.

The component is intentionally minimal, serving as a structural container. All layout positioning, sizing, and visual arrangement is the responsibility of the consumer's CSS (e.g., CSS Grid or Flexbox). The use of semantic HTML landmarks ensures the layout is navigable by screen readers and assistive technology.

## Implementation Notes

- Renders a single `<div>` wrapper element
- Consumers provide semantic HTML landmark elements as children
- No layout styles are applied; consumers use CSS Grid, Flexbox, or other techniques
- Spreads `restProps` onto the wrapper `<div>` for consumer customization

## Props

- `children`: Snippet (required) -- layout content, typically header, nav, main, aside, and footer elements

## Usage

```svelte
<HolyGrailLayout>
  <header>Site Header</header>
  <nav>Navigation</nav>
  <main>Main Content</main>
  <aside>Sidebar</aside>
  <footer>Site Footer</footer>
</HolyGrailLayout>
```

## Keyboard Interactions

None -- this component is a passive container. Navigation between landmarks is handled by assistive technology using standard landmark navigation.

## ARIA

No explicit ARIA attributes are added by this component. Accessibility is achieved through the semantic HTML landmark elements provided by the consumer (`<header>`, `<nav>`, `<main>`, `<aside>`, `<footer>`).

## References

- WAI-ARIA Landmark Regions: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
- HTML Landmarks: https://www.w3.org/WAI/tutorials/page-structure/regions/
