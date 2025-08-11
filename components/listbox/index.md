# Listbox

A listbox presents a list of selectable options using the ARIA listbox role, with full keyboard navigation support. It is used when users need to select one or more items from a visible list, as opposed to a dropdown select. Common use cases include settings panels, filter selections, multi-select interfaces, and any scenario where all options should be visible simultaneously.

The component manages focus movement between options via arrow keys, with Home and End keys to jump to the first and last items. The consumer provides option elements as children and handles selection state externally.

## Implementation Notes

- Renders a `<div>` with `role="listbox"` and an accessible label.
- Uses reactive state to track the `listRef` element reference for querying child options.
- Keyboard navigation queries all child elements with `[role='option']` to build the navigable item list.
- Arrow keys wrap around: pressing ArrowDown on the last item moves focus to the first, and vice versa.
- Home and End keys jump to the first and last option respectively.
- Spreads `restProps` onto the container for consumer customization.

## Props

- `label`: string (required) -- accessible name applied via `aria-label`.
- `children`: slot (required) -- option elements to render inside the listbox (should have `role="option"` and `tabindex="-1"`).
- `...restProps`: unknown -- additional attributes spread onto the container `<div>`.

## Usage

```html
<Listbox label="Fruits">
    <div role="option" tabindex="-1">Apple</div>
    <div role="option" tabindex="-1">Banana</div>
</Listbox>
```

```html
<Listbox label="Select a color">
    {#each colors as color}
        <div
            role="option"
            tabindex="-1"
            aria-selected={selected === color}
            onclick={() => selected = color}
        >
            {color}
        </div>
    {/each}
</Listbox>
```

## Keyboard Interactions

- ArrowDown: Moves focus to the next option, wrapping to the first option from the last.
- ArrowUp: Moves focus to the previous option, wrapping to the last option from the first.
- Home: Moves focus to the first option.
- End: Moves focus to the last option.

## ARIA

- `role="listbox"` -- identifies the container as a listbox widget for selecting from a list of options.
- `aria-label` -- provides an accessible name describing the purpose of the listbox.
- Child elements should use `role="option"` and optionally `aria-selected` to indicate selection state.

## When to Use

- Use when users need to select one or more items from a visible list of options, such as filter panels or settings.
- Use instead of a `<select>` when all options should be visible simultaneously without opening a dropdown.
- Consider using a Select or Combobox instead when space is limited or when the option list is very long.

## Headless

This headless component provides the ARIA listbox role, keyboard navigation (arrow keys, Home, End with wrapping), and focus management for child option elements. The consumer provides all visual styling, including option appearance, selected-state highlighting, scrolling behavior, and focus indicators.


## Styles

The consumer provides all CSS styling. The component renders with a `.listbox` class for targeting. No default styles are included — this is a fully headless component.


## Testing


- Verify the component renders a `<div>` element with class `listbox`
- Verify role="listbox"` -- identifies the container as a listbox widget for selecting from a list of options.
- Verify aria-label` -- provides an accessible name describing the purpose of the listbox.
- Verify Child elements should use `role="option"` and optionally `aria-selected` to indicate selection state.
- Verify keyboard interactions work correctly
- Verify pass-through attributes are applied

## Advice

- **Designers**: Provide clear visual distinction for the selected and focused option states, using both color and a non-color indicator to support color-blind users.
- **Developers**: Ensure each child option uses `role="option"` with `tabindex="-1"` and manage `aria-selected` on options to reflect the current selection state.

## References

- WAI-ARIA Listbox Pattern: https://www.w3.org/WAI/ARIA/apd/patterns/listbox/
