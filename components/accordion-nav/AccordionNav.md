# AccordionNav

An accordion nav is a navigation container that organizes and displays content in a space-efficient, collapsible format. It consists of vertically stacked sections, each with a clickable header that expands or collapses its associated content. This design helps reduce visual clutter, allowing users to focus on one section at a time while keeping other content hidden until needed. Commonly used in FAQs, filters, or mobile menus, accordions enhance usability by streamlining content access and improving navigation on both desktop and mobile interfaces.

The AccordionNav component serves as the outer wrapper. Place an AccordionList inside it, containing AccordionListItem children for the individual collapsible sections.

## Help

Use AccordionNav as the outermost container for an accordion component. Common scenarios include FAQ sections, settings panels, filter groups, and mobile navigation menus. Pair with AccordionList, AccordionListItem, AccordionSummary, and AccordionDetails.

## Syntax

```svelte
<script>
  import AccordionNav from "./AccordionNav.svelte";
</script>

<AccordionNav label="...">
  <!-- AccordionList with AccordionListItem children -->
</AccordionNav>
```

## Usage

```svelte
<AccordionNav label="FAQ">
  <AccordionList>
    <AccordionListItem>
      <AccordionSummary>Question 1</AccordionSummary>
      <AccordionDetails>Answer 1</AccordionDetails>
    </AccordionListItem>
  </AccordionList>
</AccordionNav>
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `label` | `string` | (required) | Accessible name for the accordion region via `aria-label` |
| `children` | `Snippet` | (required) | Accordion content to render inside the container |
| `...restProps` | HTML attributes | | Additional attributes spread onto the outer `<div>` |

## Examples

FAQ section:

```svelte
<AccordionNav label="Frequently asked questions">
  <AccordionList>
    <AccordionListItem summary="What is your return policy?">
      You can return items within 30 days.
    </AccordionListItem>
    <AccordionListItem summary="How do I contact support?">
      Email us at support@example.com.
    </AccordionListItem>
  </AccordionList>
</AccordionNav>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard interactions are handled by AccordionListItem children.

## ARIA

- `role="region"` -- identifies the accordion as a landmark region
- `aria-label` -- provides an accessible name for the region, allowing screen readers to announce it

## Claude Rules

- Always use `AccordionNav` (not `AccordionAreaNav` or `Accordion`)
- Always include the required `label` prop
- Pair with AccordionList, AccordionListItem, AccordionSummary, AccordionDetails
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Accordion Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/accordion/
