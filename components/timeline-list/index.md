# Timeline List

A timeline list is a UI/UX component used to visually organize and display events, steps, or data points in chronological order, helping users understand progression over time. Commonly used in project tracking, activity feeds, historical overviews, or user journeys.

This component renders as a semantic ordered list (`<ol>`) with an accessible label, conveying the chronological nature of the content to both sighted users and screen reader users. The consumer provides individual timeline entries as `<li>` children through the children slot.

## Help

Use TimelineList when you need to present a sequence of events or milestones in chronological order. Common scenarios include project milestones, order history, activity feeds, and user journey maps. Each child should be a TimelineListItem or a plain `<li>` element.

## Syntax

```html
<TimelineList label="...">
  <!-- <li> children -->
</TimelineList>
```

## Usage

```html
<TimelineList label="Project milestones">
  <li>Project kickoff - Jan 2024</li>
  <li>Alpha release - Mar 2024</li>
  <li>Beta release - Jun 2024</li>
  <li>General availability - Sep 2024</li>
</TimelineList>
```

With semantic `<time>` elements:

```html
<TimelineList label="Order history">
  <li>
    <time datetime="2024-01-15">January 15, 2024</time>
    <p>Order placed</p>
  </li>
  <li>
    <time datetime="2024-01-16">January 16, 2024</time>
    <p>Order shipped</p>
  </li>
  <li>
    <time datetime="2024-01-19">January 19, 2024</time>
    <p>Order delivered</p>
  </li>
</TimelineList>
```

## Props

| Prop           | Type            | Default    | Description                                  |
| -------------- | --------------- | ---------- | -------------------------------------------- |
| `label`        | `string`        | (required) | Accessible label via `aria-label`            |
| `children`     | `slot`       | (required) | Timeline items (should be `<li>` elements)   |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the `<ol>` |

## Examples

Activity feed:

```html
<TimelineList label="Recent activity">
  <li>
    <time datetime="2024-03-01T10:30">10:30 AM</time>
    <p>User logged in</p>
  </li>
  <li>
    <time datetime="2024-03-01T10:45">10:45 AM</time>
    <p>Updated profile settings</p>
  </li>
</TimelineList>
```

## Keyboard Interactions

- None directly -- standard list navigation by screen readers
- Tab moves focus between any interactive elements (links, buttons) within timeline items

## ARIA

- Semantic `<ol>` for ordered/chronological content
- `aria-label` provides accessible name for the list
- Consumers should use `<time>` elements with `datetime` attributes for machine-readable dates within items
## When to Use

- Use TimelineList to present a sequence of events or milestones in chronological order, such as project history, order tracking, or activity feeds.
- Use when the ordering of items conveys meaningful progression over time.
- Avoid using TimelineList for unordered or non-chronological content; use a plain list instead.
- Consider a simple list when items lack timestamps or chronological significance.

## Headless

This headless component provides a semantic `<ol>` element with `aria-label` for accessible chronological content. Screen readers convey the ordered nature of the list. The consumer provides `<li>` children (or TimelineListItem components) and all visual styling including connectors, markers, and layout.

## Advice

- **Designers**: Use visual connectors (lines, dots) between items to reinforce the chronological flow. Ensure timestamps are visually prominent.
- **Developers**: Use semantic `<time>` elements with `datetime` attributes inside each item for machine-readable dates.

## Composition

TimelineList contains TimelineListItem children following the List/ListItem pattern. TimelineList provides the `<ol>` container with accessible labeling, and each TimelineListItem provides an `<li>` for one chronological event.

## References

- HTML `<time>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time
- WAI-ARIA list role: https://www.w3.org/TR/wai-aria-1.2/#list
