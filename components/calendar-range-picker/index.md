# Calendar Range Picker

A calendar range picker is a component that allows users to select a contiguous range of dates by interacting with a visual calendar grid. Commonly used in booking systems, travel planners, analytics dashboards, and reporting tools, the calendar range picker lets users define a start date and an end date by clicking or tapping on calendar cells.

This headless component renders a `<div>` with `role="application"` and an accessible label, providing a container for rich calendar-based date range selection. The consumer provides the calendar grid content, selection logic, and visual feedback as children.

## Implementation Notes

- Renders a `<div>` with `role="application"` to support rich keyboard interactions beyond standard navigation
- Consumer provides all calendar grid rendering, date selection logic, and range highlighting
- The `role="application"` signals to screen readers that the widget handles its own keyboard interactions
- Accepts `...restProps` for forwarding additional attributes to the container

## Props

- `label`: string (required) -- accessible name describing the picker purpose, applied via `aria-label`
- `children`: slot (required) -- the calendar grid content including date cells and navigation controls

## Usage

```html
<CalendarRangePicker label="Select travel dates">
    <!-- calendar grid with date cells -->
</CalendarRangePicker>
```

## Keyboard Interactions

None built-in -- the consumer should implement date cell navigation (arrow keys), selection (Enter/Space), and range extension (Shift + arrow keys or Shift + click) as appropriate.

## ARIA

- `role="application"` -- indicates that the widget manages its own keyboard interactions, overriding standard screen reader navigation
- `aria-label={label}` -- provides an accessible name for the calendar range picker

## When to Use

- Use for selecting a contiguous date range in booking systems, travel planners, analytics dashboards, and reporting tools.
- Use when users need to visually pick both a start date and end date on a calendar grid.
- Avoid for selecting a single date -- use a date input or CalendarTable with cell selection instead.
- Consider DateInput with two fields instead when a compact, non-visual date range entry is acceptable.

## Headless

This component provides a `<div>` with `role="application"` and `aria-label` as a container for calendar-based range selection, with zero visual styling. The consumer is responsible for all rendering of the calendar grid, date cells, range highlighting, navigation controls, and all CSS including layout, colors, selected state, and hover effects.


## Styles

The consumer provides all CSS styling. The component renders with a `.calendar-range-picker` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `calendar-range-picker`
- Verify role="application"` -- indicates that the widget manages its own keyboard interactions, overriding standard screen reader navigation
- Verify aria-label={label}` -- provides an accessible name for the calendar range picker
- Verify pass-through attributes are applied

## Advice

- **Designers**: Clearly highlight the selected range with a distinct background color spanning from the start date to the end date. Show hover previews as the user moves toward the end date.
- **Developers**: Implement keyboard navigation for date cells (arrow keys), selection (Enter/Space), and range extension (Shift+click or Shift+arrow). Since `role="application"` overrides screen reader navigation, ensure all keyboard interactions are fully implemented.

## References

- WAI-ARIA Application Role: https://www.w3.org/TR/wai-aria-1.2/#application
- WAI-ARIA Grid Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/grid/
