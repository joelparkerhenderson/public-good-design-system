# TagGroup

TagGroup is a headless container for a collection of related tags. It uses the ARIA `group` role with an accessible label to semantically associate tag elements, making the collection understandable to screen readers and other assistive technologies.

This component is useful for displaying categories, skills, technologies, or any set of labels that belong together. Consumers provide the individual tag elements as children and bring their own styling.

## Implementation Notes

- Renders a `<div>` with `role="group"` to semantically group child tag elements
- Uses `aria-label` for an accessible name describing the group
- Accepts a `ChildContent` RenderFragment for rendering tag elements inside the group
- Spreads `AdditionalAttributes` onto the container for consumer customization
- Blazor 5 pattern: standard `$props()` destructuring with typed props

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TagGroup label="Technologies">
  <Tag>Svelte</Tag>
  <Tag>TypeScript</Tag>
</TagGroup>
```


## Keyboard Interactions

None -- this component is a passive container. Keyboard behavior depends on the child tag elements provided by the consumer.

## ARIA Attributes

- `role="group"` -- identifies the container as a semantic grouping of related elements
- `aria-label={label}` -- provides an accessible name describing the purpose of the tag collection

## References

- WAI-ARIA group role: https://www.w3.org/TR/wai-aria-1.2/#group
