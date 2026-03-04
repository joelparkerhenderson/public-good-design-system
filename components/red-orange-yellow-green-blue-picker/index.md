# Red Orange Yellow Green Blue Picker

A ROYGB (Red/Orange/Yellow/Green/Blue) picker is a UI/UX component that allows
users to select a five-level color-coded status value from a dropdown. ROYGB
extends the traditional RAG (Red/Amber/Green) model by adding orange and blue
levels for more granular status reporting. Red indicates a critical problem,
orange signals a hazard or significant risk, yellow means caution or minor
issues, green indicates normal on-track status, and blue represents a paused or
informational state. The component renders as a select element with appropriate
accessibility attributes, providing native keyboard navigation and screen reader
support. This headless component provides the semantic structure while allowing
consumers to apply their own visual styling.

## Implementation Notes

- Renders as `<select aria-label={label}>` with five options: red, orange, yellow, green, blue
- The `value` prop is two-way binding
- Uses native select keyboard navigation

## Props

- `label`: string (required) -- accessible label for the select
- `value`: string (default: "") -- currently selected status, bindable
- `...restProps`: Any additional HTML attributes spread onto the select

## Options

- `red`: Critical problem
- `orange`: Hazard or significant risk
- `yellow`: Caution or minor issues
- `green`: Normal, on track
- `blue`: Paused or informational

## Usage

Basic ROYGB status selection:

```html
<RedOrangeYellowGreenBluePicker label="Risk level" value={level} />
<p>Current level: {level}</p>
```

Pre-selected value:

```html
<RedOrangeYellowGreenBluePicker label="Alert status" value="green" />
```

With additional HTML attributes:

```html
<RedOrangeYellowGreenBluePicker
  label="Project health"
  value={level}
  data-dashboard="main"
/>
```

## Keyboard Interactions

- Arrow keys navigate options (native select behavior)
- Enter/Space opens the dropdown
- Escape closes the dropdown

## ARIA

- `aria-label` on the select from the label prop

## When to Use

- Use RedOrangeYellowGreenBluePicker when a five-level status scale provides more useful granularity than a three-level RAG status.
- Use RedOrangeYellowGreenBluePicker in risk assessments, health dashboards, and detailed project tracking.
- Avoid using RedOrangeYellowGreenBluePicker when a simpler three-level scale suffices; use RedAmberGreenPicker instead.
- Consider RedOrangeYellowGreenBlueView for displaying a previously selected status in read-only contexts.

## Headless

The RedOrangeYellowGreenBluePicker headless component provides a `<select>` with `aria-label` and five predefined options (red, orange, yellow, green, blue) with two-way value binding. Native select keyboard navigation is fully supported. The consumer provides all visual styling, including color coding.

## Advice

- **Designers**: Assign distinct, accessible colors to each of the five levels and always include text labels since five color-only indicators are harder to distinguish.
- **Developers**: Initialize the `value` prop to a valid default, and consider providing a placeholder option if no initial status is appropriate.

## Composition

RedOrangeYellowGreenBluePicker is the container for RedOrangeYellowGreenBluePickerButton children. Use `<RedOrangeYellowGreenBluePicker>` to wrap `<RedOrangeYellowGreenBluePickerButton>` elements, where each button represents one of the five status levels with `aria-pressed` toggle state.

## References

- Traffic Light Rating System: https://en.wikipedia.org/wiki/Traffic_light_rating_system
