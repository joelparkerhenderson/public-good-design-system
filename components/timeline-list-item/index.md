# Timeline List Item

A timeline list item is a single entry within a TimelineList, rendered as a semantic `<li>` element. Each item typically contains a timestamp (via the `<time>` element) and a description of the event or milestone.

## Help

Use TimelineListItem for individual entries within a TimelineList. Common scenarios include project milestones, order status updates, activity feed entries, and historical events. Each item should represent a single event or point in time.

## Syntax

```html
<TimelineListItem>
  <!-- event content -->
</TimelineListItem>
```

## Usage

```html
<TimelineList label="Project milestones">
  <TimelineListItem>Project kickoff - Jan 2024</TimelineListItem>
  <TimelineListItem>Alpha release - Mar 2024</TimelineListItem>
</TimelineList>
```

With semantic `<time>` elements:

```html
<TimelineList label="Order history">
  <TimelineListItem>
    <time datetime="2024-01-15">January 15, 2024</time>
    <p>Order placed</p>
  </TimelineListItem>
  <TimelineListItem>
    <time datetime="2024-01-16">January 16, 2024</time>
    <p>Order shipped</p>
  </TimelineListItem>
</TimelineList>
```

## Props

| Prop           | Type            | Default    | Description                                          |
| -------------- | --------------- | ---------- | ---------------------------------------------------- |
| `children`     | `slot`       | (required) | Content for the timeline entry                       |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<li>` element |

## Examples

Activity feed item:

```html
<TimelineListItem data-status="completed">
  <time datetime="2024-03-01T10:30">10:30 AM</time>
  <p>User completed onboarding</p>
</TimelineListItem>
```

## Keyboard Interactions

- None directly -- standard list item navigation by screen readers
- Tab moves focus between any interactive elements (links, buttons) within the item

## ARIA

- Semantic `<li>` element within an `<ol>` conveys ordered list item semantics
- Consumers should use `<time>` elements with `datetime` attributes for machine-readable dates
## References

- HTML `<li>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/li
- HTML `<time>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time
