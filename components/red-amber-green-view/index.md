# Red Amber Green View

A RAG (Red/Amber/Green) view is a component that displays a traffic-light status value as read-only text. It is used to present previously captured RAG status data in dashboards, reports, or detail views. Red indicates a critical problem, amber signals caution or minor issues, and green means everything is on track.

The component renders as a `<span>` element with an accessible label, making the status readable by screen readers and other assistive technologies. This headless component provides the semantic structure and accessibility features while allowing consumers to apply their own visual styling, such as color-coded backgrounds or text colors.

## Implementation Notes

- Renders as `<span aria-label={label}>` displaying the RAG status value as text content
- Read-only display component, not interactive
- Value defaults to an empty string when not provided
- Uses props rune for prop destructuring
- Spreads `...restProps` on the `<span>` element for consumer extensibility
- No hardcoded user-facing strings; label and value are fully configurable

## Props

- `label`: string (required) -- accessible label for screen readers via `aria-label`
- `value`: string (default: `""`) -- the RAG status to display (e.g., "red", "amber", "green")
- `...restProps`: any additional HTML attributes spread onto the `<span>` element

## Usage

```html
<RedAmberGreenView label="Project status" value="green" />
```

```html
<RedAmberGreenView label="Health check" value={status} />
```

## Keyboard Interactions

None -- this is a passive informational display, not an interactive element.

## ARIA

- `aria-label={label}` -- provides the accessible name for the status display, allowing screen readers to announce the context of the value

## When to Use

- Use RedAmberGreenView to display a RAG status in read-only dashboards, reports, summary cards, or detail views.
- Use RedAmberGreenView when the status has already been set and only needs to be presented, not edited.
- Avoid using RedAmberGreenView when users need to change the status; use RedAmberGreenPicker instead.

## Headless

The RedAmberGreenView headless component provides a `<span>` with `aria-label` for accessible naming and displays the RAG status value as text content. The consumer provides all visual styling, including color-coded backgrounds, text colors, or badge indicators.


## Styles

The consumer provides all CSS styling. The component renders with a `.red-amber-green-view` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `red-amber-green-view`
- Verify aria-label={label}` -- provides the accessible name for the status display, allowing screen readers to announce the context of the value
- Verify pass-through attributes are applied

## Advice

- **Designers**: Pair the color indicator with a text label (e.g., "Green - On track") so the status is understandable without relying on color alone.
- **Developers**: Apply CSS styles using the text content or a `data-*` attribute to dynamically color-code the display based on the status value.

## References

- WAI-ARIA status role: https://www.w3.org/TR/wai-aria-1.2/#status
