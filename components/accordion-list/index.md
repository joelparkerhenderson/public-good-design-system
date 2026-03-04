# Accordion List

An accordion list is an ordered list of accordion list items, rendered as a semantic `<ol>` element. It provides the structural grouping for collapsible sections within an AccordionNav container.

## Help

Use AccordionList as the list container inside an AccordionNav. It holds AccordionListItem children that represent the individual expandable sections. Common scenarios include FAQ lists, grouped settings, and stacked content panels.

## Syntax

```html
<AccordionList>
  <!-- AccordionListItem children -->
</AccordionList>
```

## Usage

```html
<AccordionNav label="FAQ">
  <AccordionList>
    <AccordionListItem summary="Question 1">Answer 1</AccordionListItem>
    <AccordionListItem summary="Question 2">Answer 2</AccordionListItem>
  </AccordionList>
</AccordionNav>
```

## Props

| Prop           | Type            | Default    | Description                                          |
| -------------- | --------------- | ---------- | ---------------------------------------------------- |
| `children`     | `slot`       | (required) | AccordionListItem elements to render inside the list |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<ol>` element |

## Examples

Settings panel:

```html
<AccordionNav label="Settings">
  <AccordionList>
    <AccordionListItem summary="Account">Account settings content</AccordionListItem>
    <AccordionListItem summary="Privacy">Privacy settings content</AccordionListItem>
    <AccordionListItem summary="Notifications">Notification preferences</AccordionListItem>
  </AccordionList>
</AccordionNav>
```

## Keyboard Interactions

None -- this component is a passive list container. Keyboard interactions are handled by AccordionListItem children.

## ARIA

- Semantic `<ol>` element provides ordered list semantics for assistive technology
- List structure conveys that the accordion sections are related and ordered
## When to Use

- Use for grouping multiple collapsible sections such as FAQ lists, settings panels, or stacked content panels.
- Use when you need an ordered sequence of expandable items within an AccordionNav container.
- Avoid for a single expandable section -- use a standalone Details or Collapsible component instead.

## Headless

This component provides semantic `<ol>` list structure with zero visual styling. The consumer is responsible for all CSS including list styling, spacing, borders, and visual grouping. Use the `<ol>` element or `data-*` attributes as styling hooks.

## Advice

- **Designers**: Ensure consistent spacing between accordion items and provide clear visual separation (borders or gaps) so users can distinguish individual sections.
- **Developers**: Do not add keyboard handlers to this component -- it is a passive container. Keyboard interactions are handled by AccordionListItem children.

## Composition

AccordionList follows the Nav / List / ListItem composition pattern:

- **AccordionNav** -- outer `<nav>` container providing the landmark region and accessible label.
- **AccordionList** -- `<ol>` list grouping the collapsible items in order.
- **AccordionListItem** -- individual `<details>` / `<summary>` sections for each expandable item.

```html
<AccordionNav label="FAQ">
  <AccordionList>
    <AccordionListItem summary="Question 1">Answer 1</AccordionListItem>
    <AccordionListItem summary="Question 2">Answer 2</AccordionListItem>
  </AccordionList>
</AccordionNav>
```

## References

- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
- HTML `<ol>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol
