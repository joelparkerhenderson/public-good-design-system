# TimelineListItem

A timeline list item is a single event entry within a TimelineList. It renders a semantic `<li>` element with an optional `<time>` element for machine-readable dates and a heading for the visible date text, followed by descriptive content provided through the ChildContent render fragment.

Used for project milestones, activity feeds, order histories, or any chronological sequence of events. The component supports both dated events (with `datetime` and `heading` props) and undated entries (children only).

## Implementation Notes

- Renders as `<li>` for proper semantics within a TimelineList `<ol>`
- Optionally renders a `<time>` element when `datetime` or `heading` is provided
- The `datetime` prop provides a machine-readable ISO date string
- The `heading` prop provides the visible human-readable date text
- Spreads `AdditionalAttributes` on the root `<li>` element
- Compound component: must be used inside a TimelineList

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Datetime` | `string?` | `—` | The datetime value |
| `Heading` | `string?` | `—` | The heading value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TimelineList label="Order history">
  <TimelineListItem datetime="2024-01-15" heading="January 15, 2024">
    Order placed
  </TimelineListItem>
  <TimelineListItem datetime="2024-01-16" heading="January 16, 2024">
    Order shipped
  </TimelineListItem>
  <TimelineListItem datetime="2024-01-19" heading="January 19, 2024">
    Order delivered
  </TimelineListItem>
</TimelineList>
```

Without dates:

```razor
<TimelineList label="Status updates">
  <TimelineListItem>Pending review</TimelineListItem>
  <TimelineListItem>Approved</TimelineListItem>
</TimelineList>
```


## Keyboard Interactions

- None directly -- standard list item with no interactive behavior

## ARIA Attributes

- Semantic `<li>` provides list item semantics within the parent `<ol>`
- `<time>` element with `datetime` attribute provides machine-readable date
- Screen readers announce list position from the parent `<ol>`

## References

- HTML `<time>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time
- WAI-ARIA listitem role: https://www.w3.org/TR/wai-aria-1.2/#listitem
