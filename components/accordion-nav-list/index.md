# Accordion Nav List

An accordion list is an ordered list of accordion list items, rendered as a semantic `<ol>` element. It provides the structural grouping for collapsible sections within an AccordionNav container.

## Help

Use AccordionNavList as the list container inside an AccordionNav. It holds AccordionNavListItem children that represent the individual expandable sections. Common scenarios include FAQ lists, grouped settings, and stacked content panels.

## Syntax

```html
<AccordionNavList>
  <!-- AccordionNavListItem children -->
</AccordionNavList>
```

## Usage

```html
<AccordionNav label="FAQ">
  <AccordionNavList>
    <AccordionNavListItem summary="Question 1">Answer 1</AccordionNavListItem>
    <AccordionNavListItem summary="Question 2">Answer 2</AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```

## Props

| Prop           | Type            | Default    | Description                                          |
| -------------- | --------------- | ---------- | ---------------------------------------------------- |
| `children`     | `slot`       | (required) | AccordionNavListItem elements to render inside the list |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<ol>` element |

## Examples

Settings panel:

```html
<AccordionNav label="Settings">
  <AccordionNavList>
    <AccordionNavListItem summary="Account">Account settings content</AccordionNavListItem>
    <AccordionNavListItem summary="Privacy">Privacy settings content</AccordionNavListItem>
    <AccordionNavListItem summary="Notifications">Notification preferences</AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```

## Keyboard Interactions

None -- this component is a passive list container. Keyboard interactions are handled by AccordionNavListItem children.

## ARIA

- Semantic `<ol>` element provides ordered list semantics for assistive technology
- List structure conveys that the accordion sections are related and ordered
## When to Use

- Use for grouping multiple collapsible sections such as FAQ lists, settings panels, or stacked content panels.
- Use when you need an ordered sequence of expandable items within an AccordionNav container.
- Avoid for a single expandable section -- use a standalone Details or Collapsible component instead.

## Headless

This component provides semantic `<ol>` list structure with zero visual styling. The consumer is responsible for all CSS including list styling, spacing, borders, and visual grouping. Use the `<ol>` element or `data-*` attributes as styling hooks.


## Styles

The consumer provides all CSS styling. The component renders with a `.accordion-nav-list` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<ol>` element with class `accordion-nav-list`
- Verify pass-through attributes are applied

## Advice

- **Designers**: Ensure consistent spacing between accordion items and provide clear visual separation (borders or gaps) so users can distinguish individual sections.
- **Developers**: Do not add keyboard handlers to this component -- it is a passive container. Keyboard interactions are handled by AccordionNavListItem children.

## Composition

AccordionNavList follows the Nav / List / ListItem composition pattern:

- **AccordionNav** -- outer `<nav>` container providing the landmark region and accessible label.
- **AccordionNavList** -- `<ol>` list grouping the collapsible items in order.
- **AccordionNavListItem** -- individual `<details>` / `<summary>` sections for each expandable item.

```html
<AccordionNav label="FAQ">
  <AccordionNavList>
    <AccordionNavListItem summary="Question 1">Answer 1</AccordionNavListItem>
    <AccordionNavListItem summary="Question 2">Answer 2</AccordionNavListItem>
  </AccordionNavList>
</AccordionNav>
```

## References

- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
- HTML `<ol>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol
