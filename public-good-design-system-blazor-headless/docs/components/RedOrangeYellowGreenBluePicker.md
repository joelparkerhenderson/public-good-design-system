# RedOrangeYellowGreenBluePicker

A ROYGB (Red/Orange/Yellow/Green/Blue) status input is a UI/UX component that
allows users to select a five-level color-coded status value from a dropdown.
ROYGB extends the traditional RAG (Red/Amber/Green) model by adding orange
and blue levels for more granular status reporting. Red indicates a critical
problem, orange signals a hazard or significant risk, yellow means caution or
minor issues, green indicates normal on-track status, and blue represents a
paused or informational state. The component renders as a select element with
appropriate accessibility attributes, providing native keyboard navigation and
screen reader support. This headless component provides the semantic structure
while allowing consumers to apply their own visual styling.

## Implementation Notes

- Renders as `<select aria-label={label}>` with five options: red, orange, yellow, green, blue
- The `value` prop is `@bind-` for two-way binding with `@bind-Value`
- Uses native select keyboard navigation

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Value` | `string?` | `—` | The value value |
| `ValueChanged` | `EventCallback<string>` | `—` | Event callback for two-way binding of Value |

## Usage

Basic ROYGB status selection:

```razor
@code {

  private string level = "";;
}

<RedOrangeYellowGreenBluePicker label="Risk level" @bind-Value="level" />
<p>Current level: @level</p>
```

Pre-selected value:

```razor
<RedOrangeYellowGreenBluePicker label="Alert status" value="green" />
```

With additional HTML attributes:

```razor
<RedOrangeYellowGreenBluePicker
  label="Project health"
  @bind-Value="level"
  data-dashboard="main"
/>
```


## Keyboard Interactions

- Arrow keys navigate options (native select behavior)
- Enter/Space opens the dropdown
- Escape closes the dropdown

## ARIA Attributes

- `aria-label` on the select from the label prop

## References

- Traffic Light Rating System: https://en.wikipedia.org/wiki/Traffic_light_rating_system
