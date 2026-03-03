# Timer

A timer is a UI/UX component that displays a countdown or elapsed time value
in a live-updating format. It renders as a semantic HTML `<time>` element with
`role="timer"` and `aria-live="polite"` to ensure screen readers announce
updates without interrupting the user. The component is commonly used for
session timeouts, countdowns, stopwatches, cooking timers, exam time limits,
and any scenario where users need to track the passage of time. This headless
component provides the semantic structure and accessibility features while the
consumer manages the actual timer logic and provides formatted display content
through the ChildContent render fragment.

## Implementation Notes

- Renders as `<time role="timer" aria-label={label} aria-live="polite">`
- Children snippet provides the formatted timer display text
- `aria-live="polite"` ensures screen readers announce updates without interrupting
- Consumer manages timer logic (intervals, countdowns); this component only provides structure and accessibility
- Optional `datetime` attribute can be passed via restProps for machine-readable duration (e.g. `datetime="PT5M30S"`)

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
@code {

}

<Timer label="Countdown">05:30</Timer>
```

With dynamic elapsed time:

```razor
@code {

  private int elapsed = 0;;
  let formatted = $derived(
    `${Math.floor(elapsed / 60).toString().padStart(2, "0")}:${(elapsed % 60).toString().padStart(2, "0")}`
  );

  $effect(() => {
    const interval = setInterval(() => elapsed++, 1000);
    return () => clearInterval(interval);
  });
}

<Timer label="Elapsed time">@formatted</Timer>
```

With machine-readable datetime attribute:

```razor
<Timer label="Session timeout" datetime="PT5M30S">5:30</Timer>
```


## Keyboard Interactions

- None -- this is an informational display, not interactive

## ARIA Attributes

- `role="timer"` indicates countdown or elapsed time
- `aria-label` from the label prop provides accessible name
- `aria-live="polite"` for non-intrusive screen reader announcements of updates

## References

- WAI-ARIA timer role: https://www.w3.org/TR/wai-aria-1.2/#timer
- HTML `<time>` element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/time
- ISO 8601 Duration format: https://en.wikipedia.org/wiki/ISO_8601#Durations
