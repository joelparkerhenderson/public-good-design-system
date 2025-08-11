# RedAmberGreenPicker

A RAG (Red/Amber/Green) status input is a UI/UX component that allows users to
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

Basic RAG status selection:

```razor
@code {

  private string status = "";;
}

<RedAmberGreenPicker label="Project status" @bind-Value="status" />
<p>Current status: @status</p>
```

Pre-selected value:

```razor
<RedAmberGreenPicker label="Health check" value="green" />
```

With additional HTML attributes:

```razor
<RedAmberGreenPicker
  label="Sprint status"
  @bind-Value="status"
  data-project="alpha"
/>
```


## Keyboard Interactions

- Arrow keys navigate options (native select behavior)
- Enter/Space opens the dropdown
- Escape closes the dropdown

## ARIA Attributes

- `aria-label` on the select from the label prop

## References

- RAG Status: https://en.wikipedia.org/wiki/Traffic_light_rating_system
