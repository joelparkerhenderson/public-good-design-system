# AccordionNav

A navigation container for an accordion. Renders a `<nav>` element with an accessible label, serving as the outermost wrapper for collapsible accordion content. Commonly used for FAQs, settings panels, filter groups, and mobile navigation menus.

Compound component: use with AccordionNavList and AccordionNavListItem.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<AccordionNav label="Frequently Asked Questions">
  <AccordionNavList>
    <AccordionNavListItem>
      <summary>What is this?</summary>
      <p>A design system.</p>
    </AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```



## References

- [WAI-ARIA Accordion Pattern](https://www.w3.org/WAI/ARIA/apd/patterns/accordion/)
- [HTML nav element](https://developer.mozilla.org/en-US/docs/Web/HTML/Element/nav)
