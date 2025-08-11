# Vital Sign Total Sleep Time As Min Per Day View

## Metadata

- Component: vital-sign-total-sleep-time-as-min-per-day-view
- PascalCase: VitalSignTotalSleepTimeAsMinPerDayView
- Description: number display of one vital sign total sleep time as minutes per day
- HTML tag: <div>
- CSS class: .vital-sign-total-sleep-time-as-min-per-day-view
- Interactive: no

## Companion

- vital-sign-total-sleep-time-as-min-per-day-input

## Key Behaviors

- Renders a `<span>` element with `role="img"` for a read-only display
- Uses `aria-label` for an accessible name describing the vital sign and its value
- Stores the numeric value in a `data-value` attribute for programmatic access
- Displays the value as text content within the span

## ARIA

- `role="img"` -- identifies the element as a visual representation of data
- `aria-label={label}` -- provides an accessible name describing the value

## Props

- `label`: string (required) -- accessible name for the display via `aria-label`
- `value`: number (required) -- the total sleep time value in minutes per day
- `className`: string (default: `""`) -- CSS class name for the element
- `...restProps`: unknown -- additional attributes spread onto the `<span>` element

## Acceptance Criteria

- [ ] Renders <div> element with class="vital-sign-total-sleep-time-as-min-per-day-view"
- [ ] Has aria-label attribute
- [ ] Has role="img"
- [ ] WCAG 2.2 AAA compliant
- [ ] Zero CSS — fully headless

## References

- Documentation: index.md
- CSS class: .vital-sign-total-sleep-time-as-min-per-day-view in css-style-sheet-template.css
- HTML headless: public-good-design-system-html-headless/components/vital-sign-total-sleep-time-as-min-per-day-view.html
- MDN span element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/span
