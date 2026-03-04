# Expander

An expander shows or hides additional content with a toggle button control. It is similar to a native `<details>`/`<summary>` disclosure element but uses a `<button>` trigger with `aria-expanded` for full control over behavior and presentation.

This component is useful for progressive disclosure patterns such as FAQ sections, collapsible panels, settings groups, or any interface where content should be hidden by default and revealed on demand. The expanded state is bindable, allowing parent components to programmatically control visibility.

## Implementation Notes

- Renders a `<div>` wrapper containing a `<button>` toggle and a conditional content region
- The button uses `aria-expanded` and `aria-controls` to communicate state to assistive technologies
- The content region uses `role="region"` with `aria-label` matching the button label
- A unique `contentId` is generated using `Math.random()` for the `aria-controls`/`id` link
- Supports two-way binding on the `expanded` prop
- Content is conditionally rendered with conditional rendering, removing it from the DOM when collapsed
- Uses slot for the `children` prop

## Props

- `label`: string (required) -- button text and accessible name for both the button and the content region
- `expanded`: boolean (default: false) -- bindable boolean controlling whether the content is visible
- `children`: slot (required) -- expandable content rendered when expanded is true
- `...restProps`: unknown -- additional attributes spread onto the outer `<div>` wrapper

## Usage

```html
<Expander label="Show details" expanded={expanded}>
  <p>Details here...</p>
</Expander>
```

```html
<Expander label="Advanced settings" expanded={showAdvanced}>
  <form>...</form>
</Expander>
```

## Keyboard Interactions

- Enter: Toggles the expander open/closed when the button has focus (native button behavior)
- Space: Toggles the expander open/closed when the button has focus (native button behavior)
- Tab: Moves focus to/from the toggle button

## ARIA

- `aria-expanded={expanded}` -- on the button, indicates whether the controlled content is currently visible
- `aria-controls={contentId}` -- on the button, references the id of the expandable content region
- `role="region"` -- on the content container, identifies the expandable area as a landmark region
- `aria-label={label}` -- on the content region, provides an accessible name for the region

## When to Use

- Use for progressive disclosure patterns such as FAQ sections, collapsible panels, or settings groups.
- Use when you need full control over the toggle button behavior and styling beyond what native `<details>` provides.
- Avoid for content that should always be visible; do not hide essential information behind an expander.
- Consider Details instead when native `<details>`/`<summary>` behavior is sufficient and you want a lighter implementation.

## Headless

This headless component provides a `<div>` wrapper with a `<button>` toggle using `aria-expanded` and `aria-controls`, a conditionally rendered content `<div>` with `role="region"`, and two-way binding on the `expanded` prop. The consumer provides all visual styling for the button, expanded content area, and any transition animations.

## Advice

- **Designers**: Use a visual indicator (such as a chevron or plus/minus icon) on the toggle button to communicate expandability. Animate the expand/collapse transition for a polished feel.
- **Developers**: The content region is removed from the DOM when collapsed, so any stateful children will reset. Use the bindable `expanded` prop to coordinate with parent component logic.

## References

- WAI-ARIA Disclosure Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/disclosure/
