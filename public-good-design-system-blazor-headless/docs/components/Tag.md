# Tag

A tag is a small component used to label, categorize, or indicate the status of an item. Tags are commonly used in content management systems, product listings, article metadata, and filtering interfaces to visually group or classify content. They typically display short text such as category names, keywords, status labels, or attribute values.

Tags help users quickly scan and identify relevant information, and are presented as inline elements alongside other content. This headless component renders as a `<span>` with `role="status"` and an accessible label, providing semantic structure for screen reader announcements while consumers apply their own visual styling.

## Implementation Notes

- Renders as a `<span>` element with `role="status"` and `aria-label`
- `role="status"` creates an implicit live region, so screen readers announce content changes
- All visible content is provided through the `ChildContent` snippet
- Uses Blazor 5 `$props()` for prop destructuring with additional attributes spread
- No hardcoded strings; all text comes through props for internationalization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Tag label="Category">Design</Tag>
```


```razor
<Tag label="Status">Active</Tag>
```


```razor
<Tag label="Priority: High">High</Tag>
```


## Keyboard Interactions

- None -- tags are informational, not interactive

## ARIA Attributes

- `role="status"` -- identifies this as a live region for screen reader announcements of content changes
- `aria-label` -- provides an accessible name from the `label` prop, giving expanded context beyond the visible tag text

## References

- WAI-ARIA Status Role: https://www.w3.org/TR/wai-aria-1.2/#status
