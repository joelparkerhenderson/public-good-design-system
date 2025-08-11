# Panel

A panel is a UI component that serves as a labeled container for grouping related content, controls, or settings within an interface. The Panel component renders a semantic `<section>` element with an accessible label, creating a named region landmark that assistive technology can identify and navigate to.

Panels are commonly used in dashboards, settings pages, sidebars, and multi-section layouts to organize information into logical groups. The required label ensures each panel is identifiable, which is especially important when multiple panels appear on the same page.

## Implementation Notes

- Renders a `<section>` HTML element, which creates a landmark region when labelled
- The `label` prop is required and applied via `aria-label` to name the region
- Content is provided via the `children` slot
- Rest props are spread onto the `<section>` element
- A `<section>` with `aria-label` becomes a navigable region in screen reader landmark lists

## Props

- `label`: string (required) -- accessible name for the panel region via `aria-label`
- `children`: slot (required) -- the panel content
- `...restProps`: unknown -- additional attributes spread onto the `<section>` element

## Usage

```html
<!-- Basic panel with labeled region -->
<Panel label="Settings">
  <p>Adjust your preferences below.</p>
</Panel>

<!-- Multiple panels on a page -->
<Panel label="Account information">
  <p>Name, email, and profile details.</p>
</Panel>
<Panel label="Notification preferences">
  <p>Choose how you want to be notified.</p>
</Panel>
```

## Keyboard Interactions

None -- this component is a passive container. Screen reader users can navigate to named regions using landmark navigation shortcuts.

## ARIA

- `<section aria-label="...">` -- creates a named region landmark, allowing assistive technology to list and navigate to this section
- The `aria-label` value should be concise and descriptive of the panel's content

## When to Use

- Use Panel to group related content into a labeled section on dashboards, settings pages, or multi-section layouts.
- Use Panel when you need screen reader users to navigate between distinct content regions via landmark navigation.
- Avoid using Panel for purely decorative grouping; use a plain `<div>` if no landmark semantics are needed.
- Consider Card instead when the grouped content needs a visual container with header, body, and footer areas.

## Headless

The Panel headless component provides a semantic `<section>` element with `aria-label` for region landmark navigation. It handles accessible naming and landmark semantics. The consumer provides all visual styling, including borders, backgrounds, padding, and spacing.


## Styles

The consumer provides all CSS styling. The component renders with a `.panel` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `panel`
- Verify <section aria-label="...">` -- creates a named region landmark, allowing assistive technology to list and navigate to this section
- Verify The `aria-label` value should be concise and descriptive of the panel's content
- Verify pass-through attributes are applied

## Advice

- **Designers**: Keep panel labels concise and unique on each page so users can quickly distinguish between sections in a landmark list.
- **Developers**: Ensure each Panel on a page has a distinct `label` value; duplicate region names make landmark navigation confusing for screen reader users.

## References

- WAI-ARIA region role: https://www.w3.org/TR/wai-aria-1.2/#region
- HTML section element: https://developer.mozilla.org/en-US/docs/Web/HTML/Element/section
- WAI Landmarks: https://www.w3.org/WAI/ARIA/apd/practices/landmark-regions/
