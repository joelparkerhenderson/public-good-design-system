# AccordionNavList

A grouping container for AccordionNavListItem elements within an AccordionNav. Renders a `<div>` with `role="group"` to semantically group the set of disclosure widgets.

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string?` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<AccordionNav label="FAQ">
  <AccordionNavList label="Questions">
    <AccordionNavListItem>
      <summary>What is this?</summary>
      <p>A design system.</p>
    </AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```



## References

- [WAI-ARIA group role](https://www.w3.org/TR/wai-aria-1.2/#group)
