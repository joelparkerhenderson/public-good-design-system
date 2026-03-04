# Tag Group

TagGroup is a headless container for a collection of related tags. It uses the ARIA `group` role with an accessible label to semantically associate tag elements, making the collection understandable to screen readers and other assistive technologies.

This component is useful for displaying categories, skills, technologies, or any set of labels that belong together. Consumers provide the individual tag elements as children and bring their own styling.

## Implementation Notes

- Renders a `<div>` with `role="group"` to semantically group child tag elements
- Uses `aria-label` for an accessible name describing the group
- Accepts a `children` slot for rendering tag elements inside the group
- Spreads `restProps` onto the container for consumer customization
- pattern: standard props destructuring with typed props

## Props

- `label`: string (required) -- accessible name for the group via `aria-label`
- `children`: slot (required) -- tag elements to render inside the group
- `...restProps`: unknown -- additional attributes spread onto the container `<div>`

## Usage

```html
<TagGroup label="Technologies">
  <Tag>Svelte</Tag>
  <Tag>TypeScript</Tag>
</TagGroup>
```

## Keyboard Interactions

None -- this component is a passive container. Keyboard behavior depends on the child tag elements provided by the consumer.

## ARIA

- `role="group"` -- identifies the container as a semantic grouping of related elements
- `aria-label={label}` -- provides an accessible name describing the purpose of the tag collection

## When to Use

- Use to group related Tag elements that share a common category, such as skills, technologies, article topics, or product attributes.
- Use when assistive technologies should announce the tags as a related collection.
- Avoid when tags are unrelated or scattered across different sections; group only semantically related tags.

## Headless

This headless component renders a `<div>` with `role="group"` and `aria-label` to semantically associate child tag elements. It provides grouping semantics for assistive technologies. The consumer provides all visual styling including layout (flex, grid, wrap), spacing, and gap between tags.

## Advice

- **Designers**: Use a horizontal flex-wrap layout with consistent gaps between tags. Consider a label or heading above the group to visually identify the tag category.
- **Developers**: Use a descriptive `label` prop that names the collection (e.g., "Technologies", "Skills"). Pair TagGroup with Tag children for proper semantic structure.

## Composition

TagGroup uses the Group/Item composition pattern. Place Tag components as children inside TagGroup. The TagGroup provides the `role="group"` container with an accessible label, while each Tag provides an individual labeled element within the group.

## References

- WAI-ARIA group role: https://www.w3.org/TR/wai-aria-1.2/#group
