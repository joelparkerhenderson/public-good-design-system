# AccordionNav

A navigation container for an accordion. Renders a `<nav>` element with an accessible label, serving as the outermost wrapper for collapsible accordion content. Commonly used for FAQs, settings panels, filter groups, and mobile navigation menus.

Compound component: use with AccordionNavList and AccordionNavListItem.

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| label | string | required | Accessible name via aria-label |
| children | Snippet | required | AccordionNavList element |
| ...restProps | HTML attributes | — | Spread onto the `<nav>` |

## Usage

```svelte
<AccordionNav label="Frequently Asked Questions">
  <AccordionNavList>
    <AccordionNavListItem>
      <summary>What is this?</summary>
      <p>A design system.</p>
    </AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```

## Accessibility

- `<nav>` provides navigation landmark semantics
- `aria-label` provides an accessible name for the region

## References

- [WAI-ARIA Accordion Pattern](https://www.w3.org/WAI/ARIA/apd/patterns/accordion/)
- [HTML nav element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav)
