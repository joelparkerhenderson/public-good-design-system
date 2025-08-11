# Red Amber Green Picker

A RAG (Red/Amber/Green) picker is a UI/UX component that allows users to
select a traffic-light status value from a dropdown. RAG status is one of the
most widely used status indicators in project management, dashboards, and
reporting tools. Red indicates a critical problem that needs immediate
attention, amber signals caution or minor issues, and green means everything is
on track. The component renders as a select element with appropriate
accessibility attributes, providing native keyboard navigation and screen
reader support. This headless component provides the semantic structure while
allowing consumers to apply their own visual styling.

## Implementation Notes

- Renders as `<select aria-label={label}>` with three options: red, amber, green
- The `value` prop is two-way binding
- Uses native select keyboard navigation

## Props

- `label`: string (required) -- accessible label for the select
- `value`: string (default: "") -- currently selected status, bindable
- `...restProps`: Any additional HTML attributes spread onto the select

## Options

- `red`: Critical problem, needs immediate attention
- `amber`: Caution, minor issues or at risk
- `green`: On track, everything is fine

## Usage

Basic RAG status selection:

```html
<RedAmberGreenPicker label="Project status" value={status} />
<p>Current status: {status}</p>
```

Pre-selected value:

```html
<RedAmberGreenPicker label="Health check" value="green" />
```

With additional HTML attributes:

```html
<RedAmberGreenPicker
  label="Sprint status"
  value={status}
  data-project="alpha"
/>
```

## Keyboard Interactions

- Arrow keys navigate options (native select behavior)
- Enter/Space opens the dropdown
- Escape closes the dropdown

## ARIA

- `aria-label` on the select from the label prop

## When to Use

- Use RedAmberGreenPicker in dashboards, project trackers, and reporting tools where users need to set a traffic-light status.
- Use RedAmberGreenPicker when a simple three-level severity or health indicator is sufficient.
- Avoid using RedAmberGreenPicker when more granularity is needed; use RedOrangeYellowGreenBluePicker for five-level status.
- Consider RedAmberGreenView for displaying a previously selected RAG status in read-only contexts.

## Headless

The RedAmberGreenPicker headless component provides a `<select>` with `aria-label` and three predefined options (red, amber, green) with two-way value binding. Native select keyboard navigation is fully supported. The consumer provides all visual styling, including color coding.


## Styles

The consumer provides all CSS styling. The component renders with a `.red-amber-green-picker` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `red-amber-green-picker`
- Verify aria-label` on the select from the label prop
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Color-code the options (red, amber, green) but also include text labels, as color alone is insufficient for users with color vision deficiencies.
- **Developers**: Initialize the `value` prop to a meaningful default rather than leaving it empty, so the status is always in a valid state.

## Composition

RedAmberGreenPicker is the container for RedAmberGreenPickerButton children. Use `<RedAmberGreenPicker>` to wrap `<RedAmberGreenPickerButton>` elements, where each button represents one RAG status level with `aria-pressed` toggle state.

## References

- RAG Status: https://en.wikipedia.org/wiki/Traffic_light_rating_system
