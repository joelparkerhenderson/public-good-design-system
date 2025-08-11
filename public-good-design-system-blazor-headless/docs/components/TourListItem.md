# TourListItem

A tour guide list item is a single step within a TourList guided tour. Each step represents one screen or instruction in the tour sequence. The step conditionally shows or hides based on the `current` prop, using the `hidden` attribute and `aria-hidden` for proper accessibility. Step progress information is communicated to screen readers through the accessible label.

This component is designed to be placed inside a TourList container. The consumer controls which step is current via the `current` prop, enabling flexible navigation patterns (next/previous buttons, step indicators, etc.).

## Implementation Notes

- Renders as a `<div>` with `role="group"` to semantically group step content
- Uses `aria-roledescription="step"` to identify the element as a step to screen readers
- Sets `aria-current="step"` on the active step for assistive technology
- Inactive steps use `hidden` attribute and `aria-hidden="true"` to be fully hidden
- When `stepNumber` and `totalSteps` are provided, the label includes "Step N of M" progress info
- Compound component: must be used inside a TourList container
- Spreads `AdditionalAttributes` onto the container for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Current` | `bool` | `—` | The current value |
| `StepNumber` | `string` | `—` | The step number value |
| `TotalSteps` | `string` | `—` | The total steps value |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<TourList label="Getting started" @bind-Active>
  <TourListItem label="Welcome" current={step === 0} stepNumber=@1 totalSteps=@3>
    <p>Welcome to the app!</p>
    <button @onclick="HandleClick">Next</button>
  </TourListItem>
  <TourListItem label="Features" current={step === 1} stepNumber=@2 totalSteps=@3>
    <p>Here are the features.</p>
    <button @onclick="HandleClick">Back</button>
    <button @onclick="HandleClick">Next</button>
  </TourListItem>
  <TourListItem label="Finish" current={step === 2} stepNumber=@3 totalSteps=@3>
    <p>You're all set!</p>
    <button @onclick="HandleClick">Done</button>
  </TourListItem>
</TourList>
```



## ARIA Attributes

- `role="group"` -- groups the step content semantically
- `aria-roledescription="step"` -- identifies the element as a tour step
- `aria-label` -- provides an accessible name, optionally including "Step N of M"
- `aria-current="step"` -- indicates the currently active step
- `aria-hidden="true"` -- hides inactive steps from assistive technology
- `hidden` -- hides inactive steps from visual rendering

## References

- WAI-ARIA Group Role: https://www.w3.org/TR/wai-aria-1.2/#group
- WAI-ARIA aria-roledescription: https://www.w3.org/TR/wai-aria-1.2/#aria-roledescription
- WAI-ARIA aria-current: https://www.w3.org/TR/wai-aria-1.2/#aria-current
