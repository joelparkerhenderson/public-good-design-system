# Red Orange Yellow Green Blue View

A ROYGB (Red/Orange/Yellow/Green/Blue) view is a component that displays a five-level color-coded status value as read-only text. It is used to present previously captured ROYGB status data in dashboards, reports, or detail views. Red indicates a critical problem, orange signals a hazard, yellow means caution, green indicates normal status, and blue represents a paused or informational state.

The component renders as a `<span>` element with an accessible label, making the status readable by screen readers and other assistive technologies. This headless component provides the semantic structure and accessibility features while allowing consumers to apply their own visual styling. The five-level scale offers more granularity than the traditional three-level RAG (Red/Amber/Green) status pattern.

## Implementation Notes

- Renders as `<span aria-label={label}>` displaying a ROYGB status value as text content
- Five-level status scale: red, orange, yellow, green, blue
- Read-only display component, not interactive
- Value defaults to an empty string when not provided
- Uses props rune for prop destructuring
- Spreads `...restProps` on the `<span>` element for consumer extensibility
- No hardcoded user-facing strings; label and value are fully configurable

## Props

- `label`: string (required) -- accessible label for screen readers via `aria-label`
- `value`: string (default: `""`) -- the ROYGB status to display (e.g., "red", "orange", "yellow", "green", "blue")
- `...restProps`: any additional HTML attributes spread onto the `<span>` element

## Usage

```html
<RedOrangeYellowGreenBlueView label="Risk level" value="yellow" />
```

```html
<RedOrangeYellowGreenBlueView label="Alert status" value={level} />
```

## Keyboard Interactions

None -- this is a passive informational display, not an interactive element.

## ARIA

- `aria-label={label}` -- provides the accessible name for the status display, allowing screen readers to announce the context of the value

## When to Use

- Use RedOrangeYellowGreenBlueView to display a five-level color-coded status in read-only dashboards, reports, or detail views.
- Use RedOrangeYellowGreenBlueView when the status has already been captured and only needs to be displayed.
- Avoid using RedOrangeYellowGreenBlueView when users need to change the status; use RedOrangeYellowGreenBluePicker instead.

## Headless

The RedOrangeYellowGreenBlueView headless component provides a `<span>` with `aria-label` for accessible naming and displays the ROYGB status value as text content. The consumer provides all visual styling, including color-coded backgrounds, text colors, or icons.

## Advice

- **Designers**: Use both color and text to communicate the status level, ensuring the display is understandable for users with color vision deficiencies.
- **Developers**: Apply dynamic CSS classes or inline styles based on the `value` prop to color-code the display element appropriately.

## References

- WAI-ARIA status role: https://www.w3.org/TR/wai-aria-1.2/#status
