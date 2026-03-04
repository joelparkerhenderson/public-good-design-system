# Accordion List Item

An accordion list item is a single expandable section using native HTML `<details>` / `<summary>` elements, providing built-in keyboard accessibility and toggle behavior. It is designed to be used inside an AccordionList within an AccordionNav container.

The component leverages the browser's native disclosure widget to deliver accessible expand/collapse behavior without any custom JavaScript. The `open` prop is two-way bindable, allowing parent components to programmatically control and observe the expanded state.

## Help

Use AccordionListItem for each individual collapsible section within an AccordionList. Common scenarios include FAQ question/answer pairs, expandable settings groups, and collapsible content panels. For more granular control over the header and body, use AccordionSummary and AccordionDetails as children.

## Syntax

```html
<AccordionListItem summary="...">
  <!-- expandable content -->
</AccordionListItem>
```

## Usage

Simple with summary prop:

```html
<AccordionListItem summary="Question 1">Answer 1</AccordionListItem>
```

With explicit summary and details children:

```html
<AccordionListItem>
  <AccordionSummary>Question 1</AccordionSummary>
  <AccordionDetails>Answer 1</AccordionDetails>
</AccordionListItem>
```

With bindable open state:

```html
<AccordionListItem summary="Advanced options" open={showAdvanced}>
  Advanced settings content
</AccordionListItem>
```

## Props

| Prop           | Type            | Default    | Description                                             |
| -------------- | --------------- | ---------- | ------------------------------------------------------- |
| `summary`      | `string`        | (required) | Text for the summary/header line                        |
| `open`         | `boolean`       | `false`    | Whether the item is expanded; bindable with two-way `open` binding |
| `children`     | `slot`       | (required) | Detail content rendered when expanded                   |
| `...restProps` | HTML attributes |            | Additional attributes passed to the `<details>` element |

## Examples

FAQ item:

```html
<AccordionList>
  <AccordionListItem summary="What is your return policy?">
    <p>You can return items within 30 days of purchase.</p>
  </AccordionListItem>
  <AccordionListItem summary="Do you offer free shipping?">
    <p>Free shipping on orders over $50.</p>
  </AccordionListItem>
</AccordionList>
```

## Keyboard Interactions

- Tab: Focus the summary element
- Enter / Space: Toggle open/close (browser default for `<details>`)

## ARIA

- Native `<details>` / `<summary>` provide implicit disclosure widget semantics
- Browser automatically manages expanded/collapsed state announcement
## References

- HTML details element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/details
- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
