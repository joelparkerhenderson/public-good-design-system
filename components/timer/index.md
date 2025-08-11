# Timer

A timer is a UI/UX component that displays a countdown or elapsed time value
in a live-updating format. It renders as a semantic HTML `<time>` element with
`role="timer"` and `aria-live="polite"` to ensure screen readers announce
updates without interrupting the user. The component is commonly used for
session timeouts, countdowns, stopwatches, cooking timers, exam time limits,
and any scenario where users need to track the passage of time. This headless
component provides the semantic structure and accessibility features while the
consumer manages the actual timer logic and provides formatted display content
through the children slot.

## Implementation Notes

- Renders as `<time role="timer" aria-label={label} aria-live="polite">`
- Children slot provides the formatted timer display text
- `aria-live="polite"` ensures screen readers announce updates without interrupting
- Consumer manages timer logic (intervals, countdowns); this component only provides structure and accessibility
- Optional `datetime` attribute can be passed via restProps for machine-readable duration (e.g. `datetime="PT5M30S"`)

## Props

- `label`: string (required) -- accessible label for screen readers
- `children`: slot (required) -- formatted timer display content
- `...restProps`: Any additional HTML attributes spread onto the `<time>` element

## Usage

```html
<Timer label="Countdown">05:30</Timer>
```

With dynamic elapsed time:

```html
<Timer label="Elapsed time">{formatted}</Timer>
```

With machine-readable datetime attribute:

```html
<Timer label="Session timeout" datetime="PT5M30S">5:30</Timer>
```

## Keyboard Interactions

- None -- this is an informational display, not interactive

## ARIA

- `role="timer"` indicates countdown or elapsed time
- `aria-label` from the label prop provides accessible name
- `aria-live="polite"` for non-intrusive screen reader announcements of updates

## When to Use

- Use Timer to display a countdown or elapsed time that updates live, such as session timeouts, exam limits, or cooking timers.
- Use when screen readers need to be informed of time changes via a live region.
- Avoid using Timer for static time displays; use a plain `<time>` element instead.
- Consider using a progress bar or meter when the time remaining is better represented as a proportion of a total.

## Headless

This headless component provides a `<time>` element with `role="timer"`, `aria-label`, and `aria-live="polite"` for accessible live-updating time display. The consumer manages all timer logic (intervals, countdowns) and provides formatted display content through the children slot, plus all visual styling.


## Styles

The consumer provides all CSS styling. The component renders with a `.timer` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<span>` element with class `timer`
- Verify role="timer"` indicates countdown or elapsed time
- Verify aria-label` from the label prop provides accessible name
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Use a clear, monospaced or tabular font for the timer digits to prevent layout shifts as numbers change. Consider color changes as time runs low.
- **Developers**: Provide a `datetime` attribute (e.g., `datetime="PT5M30S"`) via restProps for machine-readable duration. Manage cleanup of intervals on component unmount.

## References

- WAI-ARIA timer role: https://www.w3.org/TR/wai-aria-1.2/#timer
- HTML `<time>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time
- ISO 8601 Duration format: https://en.wikipedia.org/wiki/ISO_8601#Durations
