# Popover

A popover is a UI component that displays contextual information or actions in an overlay that appears near the element that triggered it. The Popover component provides a headless conditional dialog container that renders its content only when the `open` state is true, with proper dialog semantics for accessibility.

Unlike tooltips, popovers can contain rich interactive content such as text, forms, buttons, or other controls. The component supports two-way binding on the `open` prop, allowing parent components to control visibility. The consumer is responsible for providing trigger elements and managing open/close logic.

## Implementation Notes

- Conditionally renders a `<div>` with `role="dialog"` only when `open` is true
- Supports two-way binding on the `open` prop
- The `label` prop provides the dialog's accessible name via `aria-label`
- Rest props are spread onto the `<div>` element
- The consumer must provide their own trigger element and open/close logic
- Content is provided via the `children` slot

## Props

- `label`: string (required) -- accessible name for the popover dialog via `aria-label`
- `open`: boolean (default: false, bindable) -- controls whether the popover is visible; supports two-way binding
- `children`: slot (required) -- the popover content
- `...restProps`: unknown -- additional attributes spread onto the `<div>` element

## Usage

```html
<button onclick={() => showPopover = !showPopover}>Toggle info</button>
<Popover label="Additional information" open={showPopover}>
  <p>Here is some contextual information.</p>
  <button onclick={() => showPopover = false}>Close</button>
</Popover>
```

## Keyboard Interactions

- Escape: Consumer should implement closing the popover by setting `open` to false
- Tab: Should trap focus within the popover when open (consumer responsibility)

## ARIA

- `role="dialog"` -- identifies the popover as a dialog overlay for assistive technology
- `aria-label="..."` -- provides the accessible name for the dialog

## When to Use

- Use Popover to display rich interactive content like forms, menus, or detailed information near a trigger element.
- Use Popover when the overlay content needs to persist until the user explicitly dismisses it.
- Avoid using Popover for simple descriptive text; use Tooltip instead.
- Consider Dialog or AlertDialog when the content requires a full modal with backdrop overlay.

## Headless

The Popover headless component provides a conditionally rendered `<div>` with `role="dialog"` and `aria-label` for accessible naming. It handles open/close state via two-way binding. The consumer provides all visual styling, positioning logic, trigger elements, and focus management.


## Styles

The consumer provides all CSS styling. The component renders with a `.popover` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `popover`
- Verify role="dialog"` -- identifies the popover as a dialog overlay for assistive technology
- Verify aria-label="..."` -- provides the accessible name for the dialog
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Position popovers to avoid obscuring the trigger element, and ensure the popover has a clear visual boundary (border or shadow) to distinguish it from surrounding content.
- **Developers**: Implement focus trapping within the popover when open, and close it on Escape key press to follow the WAI-ARIA dialog pattern.

## References

- WAI-ARIA Dialog Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/dialog/
- WAI-ARIA dialog role: https://www.w3.org/TR/wai-aria-1.2/#dialog
