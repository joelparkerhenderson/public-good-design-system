# Accordion List

An accordion list is an ordered list of accordion list items, rendered as a semantic `<ol>` element. It provides the structural grouping for collapsible sections within an AccordionNav container.

## Help

Use AccordionList as the list container inside an AccordionNav. It holds AccordionListItem children that represent the individual expandable sections. Common scenarios include FAQ lists, grouped settings, and stacked content panels.

## Syntax

```svelte
<script>
  import AccordionList from "./AccordionList.svelte";
</script>

<AccordionList>
  <!-- AccordionListItem children -->
</AccordionList>
```

## Usage

```svelte
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
| `children`     | `Snippet`       | (required) | AccordionListItem elements to render inside the list |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<ol>` element |

## Examples

Settings panel:

```svelte
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

## Claude Rules

- Always use `AccordionList` (not `AccordionAreaList`)
- Always place inside an AccordionNav container
- Always use AccordionListItem as children
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
- HTML `<ol>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/ol
