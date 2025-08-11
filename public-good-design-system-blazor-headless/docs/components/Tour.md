# Tour

A tour guide is an outer container for a guided walkthrough experience, such as for sightseeing, or pathways, or demonstrations, or onboarding. It wraps a TourList and its TourListItem children, providing the dialog overlay and keyboard dismissal behavior. When active, it renders as a modal dialog that can be closed with the Escape key.

## Implementation Notes

- Conditionally renders a `<div>` with `role="dialog"` and `aria-modal="true"` when `active` is true
- Uses `aria-label` for an accessible name describing the tour
- Sets `tabindex="-1"` on the dialog to enable keyboard event capture
- Handles Escape key via an `onkeydown` handler that sets `active` to false
- Uses `$bindable(false)` for the `active` prop, enabling two-way binding
- Compound component: wraps TourList which contains TourListItem children
- Spreads `AdditionalAttributes` onto the dialog container for consumer customization

## Parameters

| Name | Type | Default | Description |
|------|------|---------|-------------|
| `CssClass` | `string?` | `—` | Additional CSS class(es) to apply |
| `Label` | `string` | `—` | Accessible label for the component |
| `Active` | `bool` | `—` | The active value |
| `ActiveChanged` | `EventCallback<bool>` | `—` | Event callback for two-way binding of Active |
| `ChildContent` | `RenderFragment` | `—` | Child content to render inside the component |

## Usage


```razor
<Tour label="Onboarding tour" @bind-Active>
  <TourList label="Tour steps">
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
</Tour>
```


## Keyboard Interactions

- Escape: closes the tour by setting `active` to false

## ARIA Attributes

- `role="dialog"` -- identifies the tour overlay as a dialog window
- `aria-modal="true"` -- indicates the dialog is modal and content behind it is inert
- `aria-label={label}` -- provides an accessible name describing the tour
- `tabindex="-1"` -- allows the dialog element to receive focus for keyboard event handling

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/
