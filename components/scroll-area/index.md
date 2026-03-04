# Scroll Area

ScrollArea is a headless scrollable container that provides keyboard accessibility for overflowing content. It renders a focusable region so keyboard users can scroll through content using standard scrolling keys without needing a mouse.

Use ScrollArea when you have content that may overflow its container, such as long lists, code blocks, chat messages, or data tables. The component provides the semantic structure and keyboard focus needed for accessible scrolling, while the consumer controls all visual styling including overflow behavior, dimensions, and scrollbar appearance.

## Implementation Notes

- Renders a `<div>` element with `role="region"` to create an accessible landmark
- Sets `tabindex="0"` to make the container focusable, enabling keyboard scrolling (arrow keys, Page Up/Down, Home/End)
- Consumer must apply CSS `overflow` and dimension properties to enable actual scrolling behavior
- Spreads `restProps` onto the div for consumer customization

## Props

- `label`: string (required) -- accessible label for the scrollable region, applied via `aria-label`
- `children`: slot (required) -- scrollable content to render inside the container
- `...restProps`: unknown -- additional attributes spread onto the `<div>` element

## Usage

```html
<ScrollArea label="Scrollable content">
  <p>Long content...</p>
</ScrollArea>
```

## Keyboard Interactions

- Tab: Moves focus to the scroll area container
- Arrow Up / Arrow Down: Scrolls content vertically (native browser behavior when focused)
- Arrow Left / Arrow Right: Scrolls content horizontally (native browser behavior when focused)
- Page Up / Page Down: Scrolls content by one page (native browser behavior when focused)
- Home / End: Scrolls to the beginning or end of content (native browser behavior when focused)

## ARIA

- `role="region"` -- identifies the container as a landmark region so assistive technologies can announce it
- `aria-label={label}` -- provides an accessible name describing what content is scrollable

## When to Use

- Use ScrollArea for content that overflows its container, such as long lists, chat messages, code blocks, or data tables.
- Use ScrollArea when keyboard users need to scroll through content without a mouse via standard scrolling keys.
- Avoid using ScrollArea for content that fits within its container; unnecessary scroll regions add complexity for assistive technology users.

## Headless

The ScrollArea headless component provides a `<div>` with `role="region"`, `aria-label`, and `tabindex="0"` for keyboard-focusable scrolling. The consumer provides all visual styling, including `overflow`, dimensions, and custom scrollbar appearance.

## Advice

- **Designers**: Indicate scrollable content with visible scrollbars, fade edges, or truncation cues so users know more content is available.
- **Developers**: Apply CSS `overflow: auto` and explicit height or max-height to enable actual scrolling; the component provides semantics only.

## Composition

ScrollArea can contain a ScrollBar child for custom scrollbar rendering. Use `<ScrollArea>` as the scrollable container and nest `<ScrollBar>` within for styled scrollbar controls that sync with the scroll position.

## References

- WAI-ARIA Region Role: https://www.w3.org/TR/wai-aria-1.2/#region
- WCAG 2.1 Reflow: https://www.w3.org/WAI/WCAG21/Understanding/reflow.html
