# Tour Guide List

TourGuideList is a headless guided walkthrough overlay that presents step-by-step instructions to users. It renders as a modal dialog when active and can be dismissed with the Escape key, providing a structured onboarding or feature discovery experience.

This component is useful for onboarding flows, feature tutorials, or contextual help systems. The `active` prop is bindable, allowing the consumer to programmatically start or stop the tour. Step content, navigation buttons, and progress indicators are provided by the consumer as children.

## Help

Use TourGuideList when you need to walk users through a sequence of steps in a modal overlay. Common scenarios include onboarding flows, feature discovery tours, and contextual help walkthroughs. Pair with TourGuideListItem for individual steps.

## Syntax

```svelte
<script>
  import TourGuideList from "./TourGuideList.svelte";
</script>

<TourGuideList label="..." bind:active>
  <!-- TourGuideListItem children -->
</TourGuideList>
```

## Usage

```svelte
<TourGuideList label="Getting started" bind:active>
  <p>Welcome to the app!</p>
</TourGuideList>
```

```svelte
<TourGuideList label="Feature tour" bind:active={showTour}>
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
| `active`       | `boolean`       | `false`    | Whether the tour is currently visible; bindable with `bind:active` |
| `children`     | `Snippet`       | (required) | Tour step content, navigation controls, and any additional UI      |
| `...restProps` | HTML attributes |            | Additional attributes spread onto the dialog `<div>`               |

## Examples

With step management:

```svelte
<script>
  import TourGuideList from "./TourGuideList.svelte";
  import TourGuideListItem from "../tour-guide-list-item/TourGuideListItem.svelte";
  let active = $state(false);
  let step = $state(0);
</script>

<button onclick={() => { active = true; step = 0; }}>Start tour</button>

<TourGuideList label="App walkthrough" bind:active>
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

## Claude Rules

- Always use `TourGuideList` (not `Tour` or `TourGuide`)
- Always include the required `label` prop
- Pair with TourGuideListItem for individual steps
- Use Svelte 5 patterns (`$bindable` for active, Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apg/patterns/dialog-modal/
