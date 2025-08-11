# TourGuideListItem

A single step within a TourGuideList guided tour. Each step represents one screen or instruction in the tour sequence. The step conditionally shows or hides based on the `current` prop, using the `hidden` attribute and `aria-hidden` for proper accessibility. Step progress information is communicated to screen readers through the accessible label.

This component is designed to be placed inside a TourGuideList container. The consumer controls which step is current via the `current` prop, enabling flexible navigation patterns (next/previous buttons, step indicators, etc.).

## Help

Use TourGuideListItem for each individual step in a TourGuideList walkthrough. Common scenarios include onboarding step content, feature highlight descriptions, and tutorial instructions. The parent TourGuideList manages the dialog overlay while each TourGuideListItem manages its own visibility.

## Syntax

```svelte
<script>
  import TourGuideListItem from "./TourGuideListItem.svelte";
</script>

<TourGuideListItem label="..." current={...}>
  <!-- step content -->
</TourGuideListItem>
```

## Usage

```svelte
<TourGuideListItem label="Welcome" current={step === 0} stepNumber={1} totalSteps={3}>
  <p>Welcome to the app!</p>
  <button onclick={() => step++}>Next</button>
</TourGuideListItem>
```

## Props

| Prop | Type | Default | Description |
|------|------|---------|-------------|
| `label` | `string` | (required) | Accessible name for this step via `aria-label` |
| `current` | `boolean` | `false` | Whether this step is the currently visible step |
| `stepNumber` | `number` | (optional) | 1-based step number (e.g. 1, 2, 3) |
| `totalSteps` | `number` | (optional) | Total number of steps in the tour |
| `children` | `Snippet` | (required) | Step content |
| `...restProps` | HTML attributes | | Additional attributes spread onto the container `<div>` |

## Examples

Multi-step tour:

```svelte
<TourGuideList label="Getting started" bind:active>
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
    <button onclick={() => active = false}>Done</button>
  </TourGuideListItem>
</TourGuideList>
```

## Keyboard Interactions

- None directly -- keyboard interactions are managed by the parent TourGuideList and by interactive elements within step content

## ARIA

- `role="group"` -- groups the step content semantically
- `aria-roledescription="step"` -- identifies the element as a tour step
- `aria-label` -- provides an accessible name, optionally including "Step N of M"
- `aria-current="step"` -- indicates the currently active step
- `aria-hidden="true"` -- hides inactive steps from assistive technology
- `hidden` -- hides inactive steps from visual rendering

## Claude Rules

- Always use `TourGuideListItem` (not `TourGuideStep` or `TourGuideItem`)
- Always include the required `label` prop
- Always place inside a TourGuideList container
- Use `stepNumber` and `totalSteps` together for progress information
- Use Svelte 5 patterns (Snippet for children)
- Component is headless/unstyled -- consumer provides all styling

## References

- WAI-ARIA Group Role: https://www.w3.org/TR/wai-aria-1.2/#group
- WAI-ARIA aria-roledescription: https://www.w3.org/TR/wai-aria-1.2/#aria-roledescription
- WAI-ARIA aria-current: https://www.w3.org/TR/wai-aria-1.2/#aria-current
