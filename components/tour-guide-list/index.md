# Tour Guide List

TourGuideList is a headless guided walkthrough overlay that presents step-by-step instructions to users. It renders as a modal dialog when active and can be dismissed with the Escape key, providing a structured onboarding or feature discovery experience.

This component is useful for onboarding flows, feature tutorials, or contextual help systems. The `active` prop is bindable, allowing the consumer to programmatically start or stop the tour. Step content, navigation buttons, and progress indicators are provided by the consumer as children.

## Help

Use TourGuideList when you need to walk users through a sequence of steps in a modal overlay. Common scenarios include onboarding flows, feature discovery tours, and contextual help walkthroughs. Pair with TourGuideListItem for individual steps.

## Syntax

```html
<TourGuideList label="..." active={active}>
  <!-- TourGuideListItem children -->
</TourGuideList>
```

## Usage

```html
<TourGuideList label="Getting started" active={active}>
  <p>Welcome to the app!</p>
</TourGuideList>
```

```html
<TourGuideList label="Feature tour" active={showTour}>
  <TourGuideListItem label="Welcome" current={step === 0} stepNumber={1} totalSteps={3}>
    <p>Welcome to the app!</p>
    <button onclick={() => step++}>Next</button>
  </TourGuideListItem>
  <TourGuideListItem label="Features" current={step === 1} stepNumber={2} totalSteps={3}>
    <p>Here are the features.</p>
    <button onclick={() => step--}>Back</button>
    <button onclick={() => step++}>Next</button>
  </TourGuideListItem>
  <TourGuideListItem label="Finish" current={step === 2} stepNumber={3} totalSteps={3}>
    <p>You're all set!</p>
    <button onclick={() => showTour = false}>Done</button>
  </TourGuideListItem>
</TourGuideList>
```

## Props

| Prop           | Type            | Default    | Description                                                        |
| -------------- | --------------- | ---------- | ------------------------------------------------------------------ |
| `label`        | `string`        | (required) | Accessible name for the tour dialog via `aria-label`               |
| `active`       | `boolean`       | `false`    | Whether the tour is currently visible; bindable with two-way `active` binding |
| `children`     | `slot`       | (required) | Tour step content, navigation controls, and any additional UI      |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the dialog `<div>`               |

## Examples

With step management:

```html
<button onclick={() => { active = true; step = 0; }}>Start tour</button>

<TourGuideList label="App walkthrough" active={active}>
  <TourGuideListItem label="Step one" current={step === 0} stepNumber={1} totalSteps={2}>
    <p>First step content</p>
    <button onclick={() => step++}>Next</button>
  </TourGuideListItem>
  <TourGuideListItem label="Step two" current={step === 1} stepNumber={2} totalSteps={2}>
    <p>Second step content</p>
    <button onclick={() => active = false}>Finish</button>
  </TourGuideListItem>
</TourGuideList>
```

## Keyboard Interactions

- Escape: Closes the tour by setting `active` to false

## ARIA

- `role="dialog"` -- identifies the tour overlay as a dialog window
- `aria-modal="true"` -- indicates the dialog is modal and content behind it is inert
- `aria-label={label}` -- provides an accessible name describing the tour
- `tabindex="-1"` -- allows the dialog element to receive focus for keyboard event handling
## When to Use

- Use TourGuideList to walk users through a step-by-step onboarding flow, feature discovery tour, or contextual help walkthrough.
- Use when guidance needs to appear as a modal overlay that focuses user attention on one step at a time.
- Avoid using TourGuideList for simple tooltips or hints; use Tooltip or InformationCallout instead.
- Consider a non-modal approach if users need to interact with the page while reading instructions.

## Headless

This headless component provides a modal `<div>` with `role="dialog"`, `aria-modal="true"`, `aria-label`, and Escape key dismissal. The consumer provides all step content, navigation buttons, progress indicators, and all visual styling including backdrop, positioning, and animations.

## Advice

- **Designers**: Include clear step progress indicators (e.g., "Step 2 of 5") and provide both "Next" and "Skip" options so users are not forced through the entire tour.
- **Developers**: Manage step state externally and pass it to TourGuideListItem children via the `current` prop. Trap focus within the dialog while active.

## Composition

TourGuideList contains TourGuideListItem children following the Guide/GuideList/GuideListItem pattern. TourGuideList provides the modal dialog overlay, and each TourGuideListItem provides one step with conditional visibility based on the `current` prop.

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/
