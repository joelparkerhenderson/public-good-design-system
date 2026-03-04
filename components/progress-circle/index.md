# Progress Circle

A progress circle indicates completion status using a `<div>` with ARIA Progress semantics. Unlike a linear progress bar, the progress circle is intended to convey progress in a radial layout, commonly used for loading indicators, completion percentages, and dashboard widgets. The component is headless, so consumers provide their own CSS to create the circular visual representation using the ARIA value attributes.

## Implementation Notes

- Renders a `<div>` with `role="Progress"` and full ARIA value attributes
- Provides `aria-valuenow`, `aria-valuemin`, and `aria-valuemax` to communicate progress to screen readers
- Accepts an optional `children` slot for content inside the circle (e.g., percentage text)
- Uses `aria-label` for accessible naming
- Spreads `restProps` for consumer customization

## Props

- `label`: string (required) -- accessible name for the progress indicator via `aria-label`
- `value`: number (default: `0`) -- current progress value
- `min`: number (default: `0`) -- minimum value of the progress range
- `max`: number (default: `100`) -- maximum value of the progress range
- `children`: slot (default: `undefined`) -- optional content rendered inside (e.g., percentage text)
- `...restProps`: unknown -- additional attributes spread onto the `<div>`

## Usage

```html
<ProgressCircle label="Upload" value={75}>
  <span>75%</span>
</ProgressCircle>
```

## Keyboard Interactions

None -- this component is a passive, read-only display.

## ARIA

- `role="Progress"` -- identifies the element as a progress indicator
- `aria-label="..."` -- provides an accessible name for the progress indicator
- `aria-valuenow` -- the current progress value
- `aria-valuemin` -- the minimum value of the progress range
- `aria-valuemax` -- the maximum value of the progress range

## When to Use

- Use ProgressCircle for compact progress displays in dashboards, widgets, and cards where a radial indicator fits the layout.
- Use ProgressCircle when you want to show a percentage inside the indicator via the children slot.
- Avoid using ProgressCircle for indeterminate loading; use ProgressSpinner instead.
- Consider Progress for standard linear progress bar layouts.

## Headless

The ProgressCircle headless component provides a `<div>` with `role="progressbar"` and full ARIA value attributes (`aria-valuenow`, `aria-valuemin`, `aria-valuemax`) plus `aria-label` for accessible naming. The consumer provides all visual styling, including the circular SVG or CSS rendering and any inner content.

## Advice

- **Designers**: Use a ring or arc visual with clear fill to indicate progress, and display the percentage value in the center of the circle for quick readability.
- **Developers**: Use the ARIA value attributes to drive your CSS or SVG arc calculations, keeping the visual and semantic states synchronized.

## References

- WAI-ARIA Meter Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/meter/
- MDN `role="Progress"`: https://developer.mozilla.org/en-US/docs/Web/Accessibility/ARIA/Roles/Progress_role
